﻿using AppKit;

namespace LeaderPivot.XAML.UNO.Host;
// This is the main entry point of the application.
public class EntryPoint
{
    static void Main(string[] args)
    {
        NSApplication.Init();
        NSApplication.SharedApplication.Delegate = new App();
        NSApplication.Main(args);
    }
}

