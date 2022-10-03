namespace Kq1DosboxTas.MemoryAccess
{
    public class Kq1AddressPointers
    {
        public static int DOSBOX_ADDRESS = 0x400000;
        public static int DOSBOX_CYCLES_OFFSET = 0x3FE090; // may be used to change the Dosbox cycles

        public static int KQ1_BASE_OFFSET = 0x1B58E20; // KQ1 base offset for Dosbox ECE r4319
        public static int KQ1_BASE_POINTER = DOSBOX_ADDRESS + KQ1_BASE_OFFSET;

        /*
         * KQ1 base-address offsets
         * ------------------------
         * KEYSTROKE_QUEUE_PTR - read as byte. This is a Dosbox memory address.
         * It cycles the 32 bytes following in increments of 2 bytes. The 2-bytes values are
         * Dosbox keycodes that are queued for the running application. Keyboard input can be
         * fed to the game by using manipulating the pointer and the keycodes that it addresses.
         *
         * All the other pointers describe different game state
         * E.g. if the menu's are showing, player position, etc.
         *
         * See
         * http://www.agidev.com/articles/agispec/agispecs.html
         * http://agiwiki.sierrahelp.com/
         *
         *
         */
        public static int KEYSTROKE_QUEUE_PTR = 0x41C;
        public static int MENU_STATE1_PTR = 0x450;
        public static int MENU_STATE2_PTR = 0x451;
        public static int GAME_COUNTER_PTR = 0x46C;
        public static int CURRENT_ROOM_PTR = 0x126E9;
        public static int GAME_SCORE_PTR = 0x126EC;
        public static int PLAYER_DIR_PTR = 0x126EF;
        public static int GAME_SPEED_PTR = 0x126F3;
        public static int SECONDS_PASSED_PTR = 0x126F4;
        public static int MINUTES_PASSED_PTR = 0x126F5;
        public static int FLAGBYTE1_PTR = 0x127EA;
        public static int FLAGBYTE2_PTR = 0x127EB;
        public static int DIALOG_SHOWING_PTR = 0x133E7;
        public static int RESTART_SHOWING_PTR = 0x138F3;
        public static int RANDOM_SEED_PTR = 0x13DE7;
        public static int MOVE_X_PTR = 0x16170;
        public static int MOVE_Y_PTR = 0x16172;
        public static int WALK_CYCLE_PTR = 0x1617B;
        public static int NPC_DIRECTION_PTR = 0x161B9;
        public static int PLAYER_XPOS_PTR = 0x16183;
        public static int PLAYER_YPOS_PTR = 0x16185;
        public static int NPC_XPOS_PTR = 0x1619B;
        public static int NPC_YPOS_PTR = 0x1619D;
    }
}
