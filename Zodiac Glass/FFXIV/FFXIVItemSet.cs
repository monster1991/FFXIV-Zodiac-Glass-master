namespace ZodiacGlass.FFXIV
{
    using System.Diagnostics;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit, Size = FFXIVStructSizes.ItemSet)]
    internal unsafe struct FFXIVItemSet
    {
        [FieldOffset(0)]
        public fixed byte raw[FFXIVStructSizes.ItemSet];

        [FieldOffset(8)]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly FFXIVWeapon weapon;

        [FieldOffset(64)]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly FFXIVWeapon shield;

        [FieldOffset(120)]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly FFXIVItem head;

        [FieldOffset(176)]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly FFXIVItem body;

        [FieldOffset(232)]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly FFXIVItem heands;

        [FieldOffset(288)]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly FFXIVItem waist;

        [FieldOffset(344)]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly FFXIVItem pants;

        [FieldOffset(400)]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly FFXIVItem feet;

        [FieldOffset(456)]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly FFXIVItem earrings;

        [FieldOffset(512)]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly FFXIVItem necklace;

        [FieldOffset(568)]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly FFXIVItem bracelets;

        [FieldOffset(624)]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly FFXIVItem ring1;

        [FieldOffset(680)]
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly FFXIVItem ring2;

        public FFXIVWeapon Weapon
        {
            get
            {
                return this.weapon;
            }
        }

        public FFXIVWeapon Shield
        {
            get
            {
                return this.shield;
            }
        }

        public FFXIVItem Head
        {
            get
            {
                return this.head;
            }
        }

        public FFXIVItem Body
        {
            get
            {
                return this.body;
            }
        }

        public FFXIVItem Heands
        {
            get
            {
                return this.heands;
            }
        }

        public FFXIVItem Waist
        {
            get
            {
                return this.waist;
            }
        }

        public FFXIVItem Pants
        {
            get
            {
                return this.pants;
            }
        }

        public FFXIVItem Feet
        {
            get
            {
                return this.feet;
            }
        }

        public FFXIVItem Earrings
        {
            get
            {
                return this.earrings;
            }
        }

        public FFXIVItem Necklace
        {
            get
            {
                return this.necklace;
            }
        }

        public FFXIVItem Bracelets
        {
            get
            {
                return this.bracelets;
            }
        }
        public FFXIVItem Ring1
        {
            get
            {
                return this.ring1;
            }
        }
        public FFXIVItem Ring2
        {
            get
            {
                return this.ring2;
            }
        }
    }

    //[StructLayout(LayoutKind.Explicit, Size = FFXIVStructSizes.ItemSet)]
    //internal unsafe struct FFXIVItemSet_DX11
    //{
    //    [FieldOffset(0)]
    //    public fixed byte raw[FFXIVStructSizes.ItemSet];

    //    [FieldOffset(8)]
    //    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    //    private readonly FFXIVItem weapon;

    //    //[FieldOffset(72)] x86
    //    [FieldOffset(64)]
    //    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    //    private readonly FFXIVItem shield;

    //    [FieldOffset(120)]
    //    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    //    private readonly FFXIVItem head;

    //    [FieldOffset(176)]
    //    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    //    private readonly FFXIVItem body;

    //    [FieldOffset(232)]
    //    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    //    private readonly FFXIVItem heands;

    //    [FieldOffset(288)]
    //    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    //    private readonly FFXIVItem waist;

    //    [FieldOffset(344)]
    //    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    //    private readonly FFXIVItem pants;

    //    [FieldOffset(400)]
    //    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    //    private readonly FFXIVItem feet;

    //    [FieldOffset(456)]
    //    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    //    private readonly FFXIVItem earrings;

    //    [FieldOffset(512)]
    //    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    //    private readonly FFXIVItem necklace;

    //    [FieldOffset(568)]
    //    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    //    private readonly FFXIVItem bracelets;

    //    [FieldOffset(624)]
    //    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    //    private readonly FFXIVItem ring1;

    //    [FieldOffset(680)]
    //    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    //    private readonly FFXIVItem ring2;

    //    public FFXIVItem Weapon
    //    {
    //        get
    //        {
    //            return this.weapon;
    //        }
    //    }

    //    public FFXIVItem Shield
    //    {
    //        get
    //        {
    //            return this.shield;
    //        }
    //    }

    //    public FFXIVItem Head
    //    {
    //        get
    //        {
    //            return this.head;
    //        }
    //    }

    //    public FFXIVItem Body
    //    {
    //        get
    //        {
    //            return this.body;
    //        }
    //    }

    //    public FFXIVItem Heands
    //    {
    //        get
    //        {
    //            return this.heands;
    //        }
    //    }

    //    public FFXIVItem Waist
    //    {
    //        get
    //        {
    //            return this.waist;
    //        }
    //    }

    //    public FFXIVItem Pants
    //    {
    //        get
    //        {
    //            return this.pants;
    //        }
    //    }

    //    public FFXIVItem Feet
    //    {
    //        get
    //        {
    //            return this.feet;
    //        }
    //    }

    //    public FFXIVItem Earrings
    //    {
    //        get
    //        {
    //            return this.earrings;
    //        }
    //    }

    //    public FFXIVItem Necklace
    //    {
    //        get
    //        {
    //            return this.necklace;
    //        }
    //    }

    //    public FFXIVItem Bracelets
    //    {
    //        get
    //        {
    //            return this.bracelets;
    //        }
    //    }
    //    public FFXIVItem Ring1
    //    {
    //        get
    //        {
    //            return this.ring1;
    //        }
    //    }
    //    public FFXIVItem Ring2
    //    {
    //        get
    //        {
    //            return this.ring2;
    //        }
    //    }
    //}
}
