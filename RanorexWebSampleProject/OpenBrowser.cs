﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace RanorexWebSampleProject
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The OpenBrowser recording.
    /// </summary>
    [TestModule("8b1d654b-077d-4327-be94-b5b58279de16", ModuleType.Recording, 1)]
    public partial class OpenBrowser : ITestModule
    {
        /// <summary>
        /// Holds an instance of the RanorexWebSampleProjectRepository repository.
        /// </summary>
        public static RanorexWebSampleProjectRepository repo = RanorexWebSampleProjectRepository.Instance;

        static OpenBrowser instance = new OpenBrowser();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public OpenBrowser()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static OpenBrowser Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Website", "Opening web site 'https://www.ranorex.com/free-trial/' with browser 'chrome' in normal mode.", new RecordItemIndex(0));
            Host.Current.OpenBrowser("https://www.ranorex.com/free-trial/", "chrome", "", false, false, false, false, false, false, false, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(1));
            Delay.Duration(10000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
