		[DllImport("kernel32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool AllocConsole();
    
    AllocConsole(); // make console gay
