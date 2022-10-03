using Kq1DosboxTas.MemoryAccess;
using static Kq1DosboxTas.MemoryAccess.Kq1AddressPointers;

namespace Kq1DosboxTas.GameManipulation
{
    class GameInfoText
    {
        private Kq1ReadWrite kq1ReadWrite;

        public GameInfoText(Kq1ReadWrite kq1ReadWrite)
        {
            this.kq1ReadWrite = kq1ReadWrite;
        }

        public string UpdateText()
        {
            int playerX = kq1ReadWrite.ReadByte(PLAYER_XPOS_PTR);
            int playerY = kq1ReadWrite.ReadByte(PLAYER_YPOS_PTR);
            int currentRoom = kq1ReadWrite.ReadByte(CURRENT_ROOM_PTR);
            int seed = kq1ReadWrite.ReadTwoByte(RANDOM_SEED_PTR);
            int cycles = kq1ReadWrite.ReadDosboxCycles();
            string reportStr = "";
            string[] labels = { "pos-x", "pos-y", "room", "seed", "Dosbox-cycles" };
            reportStr += $"{labels[0].PadRight(13)} {playerX,6}\n";
            reportStr += $"{labels[1].PadRight(13)} {playerY,6}\n";
            reportStr += $"{labels[2].PadRight(13)} {currentRoom,6}\n";
            reportStr += $"{labels[3].PadRight(13)} {seed,6}\n";
            reportStr += $"{labels[4].PadRight(13)} {cycles,6}\n";
            return reportStr;
        }
    }
}
