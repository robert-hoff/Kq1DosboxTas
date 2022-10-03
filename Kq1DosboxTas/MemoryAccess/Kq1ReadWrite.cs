using static Kq1DosboxTas.MemoryAccess.Kq1AddressPointers;

namespace Kq1DosboxTas.MemoryAccess
{
    class Kq1ReadWrite
    {
        private int KQ1_BASE_ADDRESS;

        public Kq1ReadWrite()
        {
            MemoryInterface.Initialize("DOSBox");
            KQ1_BASE_ADDRESS = MemoryReadWrite.ReadInt(KQ1_BASE_POINTER);
        }

        public int ReadByte(int ptr)
        {
            return MemoryReadWrite.ReadByte(KQ1_BASE_ADDRESS + ptr);
        }

        public int ReadTwoByte(int ptr)
        {
            return MemoryReadWrite.ReadTwoByte(KQ1_BASE_ADDRESS + ptr);
        }

        public void WriteByte(int val, int ptr)
        {
            MemoryReadWrite.WriteByte(val, KQ1_BASE_ADDRESS + ptr);
        }

        public void WriteTwoByte(int val, int ptr)
        {
            MemoryReadWrite.WriteTwoByte(val, KQ1_BASE_ADDRESS + ptr);
        }

        public void SetRandomSeed(int val)
        {
            MemoryReadWrite.WriteTwoByte(val, KQ1_BASE_ADDRESS + RANDOM_SEED_PTR);
        }

        public bool ReadRestartMenuShowing()
        {
            return ReadByte(RESTART_SHOWING_PTR) == 1;
        }
        public bool DialogShowing()
        {
            return ReadByte(DIALOG_SHOWING_PTR) == 1;
        }
        public int ReadDosboxCycles()
        {
            return MemoryReadWrite.ReadInt(DOSBOX_ADDRESS + DOSBOX_CYCLES_OFFSET);
        }

        public void SetDosboxCycles(int val)
        {
            MemoryReadWrite.WriteInt(val, DOSBOX_ADDRESS + DOSBOX_CYCLES_OFFSET);
        }
    }
}

