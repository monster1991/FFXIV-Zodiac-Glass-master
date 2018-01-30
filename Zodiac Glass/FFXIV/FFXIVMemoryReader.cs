namespace ZodiacGlass.FFXIV
{
    using System;
    using System.Diagnostics;
    using System.Reflection;
    using System.Runtime.InteropServices;
    using ZodiacGlass.FFXIV;
    using ZodiacGlass.Native;

    internal unsafe class FFXIVMemoryReader : IDisposable
    {
        #region Fields
        public Diagnostics.Log log = new Diagnostics.Log();

        private readonly Process process;

        private readonly IntPtr processHandel;

        private readonly FFXIVMemoryMap memMep;

        #endregion

        #region Constructors

        public FFXIVMemoryReader(Process process, FFXIVMemoryMap memMep)
        {
            if (process == null)
                throw new ArgumentNullException(MethodBase.GetCurrentMethod().GetParameters()[0].Name);

            if (memMep == null)
                throw new ArgumentNullException(MethodBase.GetCurrentMethod().GetParameters()[1].Name);

            this.process = process;
            this.memMep = memMep;

            if (!this.process.HasExited)
            {
                this.processHandel = NativeMethods.OpenProcess(ProcessAccessFlags.VirtualMemoryRead | ProcessAccessFlags.QueryInformation, false, this.process.Id);
            }
        }
        
        #endregion

        #region Properties


        public Process Process
        {
            get { return this.process; }
        }
        

        #endregion

        #region Functions

        public FFXIVItemSet ReadItemSet()
        {
            unsafe
            {
                if (!this.process.HasExited)
                {
                    int* p;

                    if (this.process.ProcessName.IndexOf("dx11") >= 0 )
                    {
                        p = (int*)(this.process.MainModule.BaseAddress + this.memMep.ItemSetPointer.BaseAddressOffset[0]);

                        p = (int*)(this.Read<int>(p) + this.memMep.ItemSetPointer.Offsets[0]);
                        p = (int*)(this.Read<int>(p) + this.memMep.ItemSetPointer.Offsets[1]);
                    }
                    else
                    {
                        p = (int*)(this.process.MainModule.BaseAddress + this.memMep.ItemSetPointer.BaseAddressOffset[1]);

                        p = (int*)(this.Read<int>(p) + this.memMep.ItemSetPointer.Offsets[2]);
                        p = (int*)(this.Read<int>(p) + this.memMep.ItemSetPointer.Offsets[3]);
                    }

                    this.log.Write(Diagnostics.LogLevel.Info, "Setting Read FFXIVItemSet()");
                    return this.Read<FFXIVItemSet>(p);
                }
                else
                {
                    this.log.Write(Diagnostics.LogLevel.Info,"Setting Default FFXIVItemSet()");
                    return default(FFXIVItemSet);
                }
            }
        }

        private unsafe T Read<T>(void* p) where T : struct
        {
            byte[] buffer = new byte[Marshal.SizeOf(default(T))];
            int readCount;

            NativeMethods.TryReadProcessMemory(this.processHandel, (IntPtr)p, ref buffer, buffer.Length, out readCount);

            fixed (byte* pBuffer = &buffer[0])
            {
                return (T)Marshal.PtrToStructure((IntPtr)pBuffer, typeof(T));
            }
        }

        public void Dispose()
        {
            NativeMethods.CloseHandle(this.processHandel);
        }

        #endregion
    }
}
