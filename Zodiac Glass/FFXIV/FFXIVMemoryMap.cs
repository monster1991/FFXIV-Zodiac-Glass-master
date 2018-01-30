namespace ZodiacGlass.FFXIV
{
    using System;
    using System.Linq;

    public class FFXIVMemoryMap
    {
        private static readonly Lazy<FFXIVMemoryMap> _default = new Lazy<FFXIVMemoryMap>(() => new FFXIVMemoryMap() { ItemSetPointer =
            //new FFXIVPointer() { BaseAddressOffset = 0x010375E8, Offsets = new int[] { 0x40, 0x0 } }
            new FFXIVPointer() { BaseAddressOffset = new int[] { 0x017A2438, 0x010F1B44 }, Offsets = new int[] { 0x60, 0x0, 0x40, 0x0 } }
        });

        public static FFXIVMemoryMap Default
        {
            get
            {
                return _default.Value;
            }
        }

        public FFXIVPointer ItemSetPointer { get; set; }

        public override int GetHashCode()
        {
            return this.ItemSetPointer.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            FFXIVMemoryMap other = obj as FFXIVMemoryMap;
            return other != null && this.ItemSetPointer.Equals(other.ItemSetPointer);
        }
    }
}
