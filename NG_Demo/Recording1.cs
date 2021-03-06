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

namespace NG_Demo
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording1 recording.
    /// </summary>
    [TestModule("739e7ca3-5d07-4aa3-8d0d-7c4b6e15fa7d", ModuleType.Recording, 1)]
    public partial class Recording1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the NG_DemoRepository repository.
        /// </summary>
        public static NG_DemoRepository repo = NG_DemoRepository.Instance;

        static Recording1 instance = new Recording1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording1()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording1 Instance
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
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RanorexVIPDatabaseTestWebApplicatio.FirstName' at .145;.333.", repo.RanorexVIPDatabaseTestWebApplicatio.FirstNameInfo, new RecordItemIndex(0));
            repo.RanorexVIPDatabaseTestWebApplicatio.FirstName.Click(".145;.333");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Jason' with focus on 'RanorexVIPDatabaseTestWebApplicatio.FirstName'.", repo.RanorexVIPDatabaseTestWebApplicatio.FirstNameInfo, new RecordItemIndex(1));
            repo.RanorexVIPDatabaseTestWebApplicatio.FirstName.PressKeys("Jason");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RanorexVIPDatabaseTestWebApplicatio.LastName' at .086;.944.", repo.RanorexVIPDatabaseTestWebApplicatio.LastNameInfo, new RecordItemIndex(2));
            repo.RanorexVIPDatabaseTestWebApplicatio.LastName.Click(".086;.944");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'bRanham' with focus on 'RanorexVIPDatabaseTestWebApplicatio.LastName'.", repo.RanorexVIPDatabaseTestWebApplicatio.LastNameInfo, new RecordItemIndex(3));
            repo.RanorexVIPDatabaseTestWebApplicatio.LastName.PressKeys("bRanham");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RanorexVIPDatabaseTestWebApplicatio.Movie' at .095;.5.", repo.RanorexVIPDatabaseTestWebApplicatio.MovieInfo, new RecordItemIndex(4));
            repo.RanorexVIPDatabaseTestWebApplicatio.Movie.Click(".095;.5");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RanorexVIPDatabaseTestWebApplicatio.Gender' at .615;.385.", repo.RanorexVIPDatabaseTestWebApplicatio.GenderInfo, new RecordItemIndex(5));
            repo.RanorexVIPDatabaseTestWebApplicatio.Gender.Click(".615;.385");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RanorexVIPDatabaseTestWebApplicatio.InputTagAdd' at .58;.417.", repo.RanorexVIPDatabaseTestWebApplicatio.InputTagAddInfo, new RecordItemIndex(6));
            repo.RanorexVIPDatabaseTestWebApplicatio.InputTagAdd.Click(".58;.417");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='VIP count: 1') on item 'RanorexVIPDatabaseTestWebApplicatio.Count'.", repo.RanorexVIPDatabaseTestWebApplicatio.CountInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.RanorexVIPDatabaseTestWebApplicatio.CountInfo, "InnerText", "VIP count: 1");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
