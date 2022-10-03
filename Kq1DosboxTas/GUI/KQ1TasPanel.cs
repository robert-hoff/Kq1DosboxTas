using Kq1DosboxTas.GameManipulation;
using Kq1DosboxTas.MemoryAccess;
using static Kq1DosboxTas.MemoryAccess.Kq1AddressPointers;
using static Kq1DosboxTas.MemoryAccess.Kq1KeyCodes;

namespace Kq1DosboxTas.GUI
{
    public partial class KQ1TasPanel : Form
    {
        Kq1ReadWrite kq1ReadWrite = new Kq1ReadWrite();

        public KQ1TasPanel()
        {
            InitializeComponent();
            this.Text = "KQ1 Player Controller";
            this.Size = new Size(600, 300);
            StartPosition = FormStartPosition.Manual;
            Location = new Point(200, 200);
            this.Load += OnFormLoad;
        }
        private void OnFormLoad(object sender, System.EventArgs e)
        {
            Thread threadGameInfo = new(new ThreadStart(this.GameInfoThread));
            threadGameInfo.IsBackground = true;
            threadGameInfo.Start();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // close on Esc
            if (keyData == Keys.Escape)
            {
                Close();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void GameInfoThread()
        {
            GameInfoText gameInfo = new GameInfoText(kq1ReadWrite);
            while (true)
            {
                MethodInvoker invoker = delegate
                {
                    labelGameInfo.Text = gameInfo.UpdateText();
                };
                this.Invoke(invoker);
                Thread.Sleep(50);
            }
        }

        private int KeyCodeOffset(int inputPointer)
        {
            return KEYSTROKE_QUEUE_PTR + inputPointer - 28;
        }
        private int IncrementKeyQueuePointer(int p)
        {
            return p + 2 > 60 ? 30 : p + 2;
        }
        private void SendKeyBoardInput((int, int) keyCode)
        {
            int inputPointer = kq1ReadWrite.ReadByte(KEYSTROKE_QUEUE_PTR);
            kq1ReadWrite.WriteTwoByte(keyCode.Item1, KeyCodeOffset(inputPointer));
            kq1ReadWrite.WriteByte(IncrementKeyQueuePointer(inputPointer), KEYSTROKE_QUEUE_PTR);
        }


        private void sendKey7(object sender, EventArgs e)
        {
            SendKeyBoardInput(KEY_7);
        }
        private void sendKey8(object sender, EventArgs e)
        {
            SendKeyBoardInput(KEY_8);
        }
        private void sendKey9(object sender, EventArgs e)
        {
            SendKeyBoardInput(KEY_9);
        }
        private void sendKey4(object sender, EventArgs e)
        {
            SendKeyBoardInput(KEY_4);
        }
        private void sendKey6(object sender, EventArgs e)
        {
            SendKeyBoardInput(KEY_6);
        }
        private void sendKey1(object sender, EventArgs e)
        {
            SendKeyBoardInput(KEY_1);
        }
        private void sendKey2(object sender, EventArgs e)
        {
            SendKeyBoardInput(KEY_2);
        }
        private void sendKey3(object sender, EventArgs e)
        {
            SendKeyBoardInput(KEY_3);
        }


        private int cycleInd = 0;
        private int[] cycleValues = { 121900, 3000, 10000, 20000, 60000 };
        private void buttonChangeDosboxCycles(object sender, EventArgs e)
        {
            cycleInd = (cycleInd + 1) % cycleValues.Length;
            kq1ReadWrite.SetDosboxCycles(cycleValues[cycleInd]);
        }
    }
}
