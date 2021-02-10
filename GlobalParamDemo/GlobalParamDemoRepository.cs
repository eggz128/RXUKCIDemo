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
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace GlobalParamDemo
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the GlobalParamDemoRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("29440e86-0cab-4ee3-a302-59570bc7540b")]
    public partial class GlobalParamDemoRepository : RepoGenBaseFolder
    {
        static GlobalParamDemoRepository instance = new GlobalParamDemoRepository();
        GlobalParamDemoRepositoryFolders.MainFormAppFolder _mainform;
        GlobalParamDemoRepositoryFolders.KeePassAppFolder _keepass;
        GlobalParamDemoRepositoryFolders.AboutFormAppFolder _aboutform;

        /// <summary>
        /// Gets the singleton class instance representing the GlobalParamDemoRepository element repository.
        /// </summary>
        [RepositoryFolder("29440e86-0cab-4ee3-a302-59570bc7540b")]
        public static GlobalParamDemoRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public GlobalParamDemoRepository() 
            : base("GlobalParamDemoRepository", "/", null, 0, false, "29440e86-0cab-4ee3-a302-59570bc7540b", ".\\RepositoryImages\\GlobalParamDemoRepository29440e86.rximgres")
        {
            _mainform = new GlobalParamDemoRepositoryFolders.MainFormAppFolder(this);
            _keepass = new GlobalParamDemoRepositoryFolders.KeePassAppFolder(this);
            _aboutform = new GlobalParamDemoRepositoryFolders.AboutFormAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("29440e86-0cab-4ee3-a302-59570bc7540b")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The MainForm folder.
        /// </summary>
        [RepositoryFolder("926d6a89-58db-4cc4-9aef-9fc4428220b5")]
        public virtual GlobalParamDemoRepositoryFolders.MainFormAppFolder MainForm
        {
            get { return _mainform; }
        }

        /// <summary>
        /// The KeePass folder.
        /// </summary>
        [RepositoryFolder("42d5dd76-1695-4ab3-9551-30a2fa7d1a8d")]
        public virtual GlobalParamDemoRepositoryFolders.KeePassAppFolder KeePass
        {
            get { return _keepass; }
        }

        /// <summary>
        /// The AboutForm folder.
        /// </summary>
        [RepositoryFolder("2d5a38bb-cdd5-497f-9fa5-b6abb0a15d28")]
        public virtual GlobalParamDemoRepositoryFolders.AboutFormAppFolder AboutForm
        {
            get { return _aboutform; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class GlobalParamDemoRepositoryFolders
    {
        /// <summary>
        /// The MainFormAppFolder folder.
        /// </summary>
        [RepositoryFolder("926d6a89-58db-4cc4-9aef-9fc4428220b5")]
        public partial class MainFormAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _helpInfo;

            /// <summary>
            /// Creates a new MainForm  folder.
            /// </summary>
            public MainFormAppFolder(RepoGenBaseFolder parentFolder) :
                    base("MainForm", "/form[@controlname='MainForm']", parentFolder, 30000, null, true, "926d6a89-58db-4cc4-9aef-9fc4428220b5", "")
            {
                _helpInfo = new RepoItemInfo(this, "Help", "?/?/menuitem[@accessiblename='Help']", 30000, null, "1172e417-4b18-4860-9ef4-3e89d91da78d");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("926d6a89-58db-4cc4-9aef-9fc4428220b5")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("926d6a89-58db-4cc4-9aef-9fc4428220b5")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Help item.
            /// </summary>
            [RepositoryItem("1172e417-4b18-4860-9ef4-3e89d91da78d")]
            public virtual Ranorex.MenuItem Help
            {
                get
                {
                    return _helpInfo.CreateAdapter<Ranorex.MenuItem>(true);
                }
            }

            /// <summary>
            /// The Help item info.
            /// </summary>
            [RepositoryItemInfo("1172e417-4b18-4860-9ef4-3e89d91da78d")]
            public virtual RepoItemInfo HelpInfo
            {
                get
                {
                    return _helpInfo;
                }
            }
        }

        /// <summary>
        /// The KeePassAppFolder folder.
        /// </summary>
        [RepositoryFolder("42d5dd76-1695-4ab3-9551-30a2fa7d1a8d")]
        public partial class KeePassAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _aboutkeepassInfo;

            /// <summary>
            /// Creates a new KeePass  folder.
            /// </summary>
            public KeePassAppFolder(RepoGenBaseFolder parentFolder) :
                    base("KeePass", "/contextmenu[@processname='KeePass']", parentFolder, 30000, null, true, "42d5dd76-1695-4ab3-9551-30a2fa7d1a8d", "")
            {
                _aboutkeepassInfo = new RepoItemInfo(this, "AboutKeePass", "menuitem[@accessiblename='About KeePass...']", 30000, null, "b6722db4-5111-4d61-86e8-72e1c5dae4a0");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("42d5dd76-1695-4ab3-9551-30a2fa7d1a8d")]
            public virtual Ranorex.ContextMenu Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.ContextMenu>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("42d5dd76-1695-4ab3-9551-30a2fa7d1a8d")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The AboutKeePass item.
            /// </summary>
            [RepositoryItem("b6722db4-5111-4d61-86e8-72e1c5dae4a0")]
            public virtual Ranorex.MenuItem AboutKeePass
            {
                get
                {
                    return _aboutkeepassInfo.CreateAdapter<Ranorex.MenuItem>(true);
                }
            }

            /// <summary>
            /// The AboutKeePass item info.
            /// </summary>
            [RepositoryItemInfo("b6722db4-5111-4d61-86e8-72e1c5dae4a0")]
            public virtual RepoItemInfo AboutKeePassInfo
            {
                get
                {
                    return _aboutkeepassInfo;
                }
            }
        }

        /// <summary>
        /// The AboutFormAppFolder folder.
        /// </summary>
        [RepositoryFolder("2d5a38bb-cdd5-497f-9fa5-b6abb0a15d28")]
        public partial class AboutFormAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _cell240Info;
            RepoItemInfo _mbtnokInfo;

            /// <summary>
            /// Creates a new AboutForm  folder.
            /// </summary>
            public AboutFormAppFolder(RepoGenBaseFolder parentFolder) :
                    base("AboutForm", "/form[@controlname='AboutForm']", parentFolder, 30000, null, true, "2d5a38bb-cdd5-497f-9fa5-b6abb0a15d28", "")
            {
                _cell240Info = new RepoItemInfo(this, "Cell240", "table[@controlname='m_lvComponents']/?/?/cell[@text='2.40']", 30000, null, "cbf02276-e9aa-40b1-9e4a-db35a94a2836");
                _mbtnokInfo = new RepoItemInfo(this, "MBtnOK", "button[@controlname='m_btnOK']", 30000, null, "f36f0f04-6571-4d07-8ab9-9a8a14993f83");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("2d5a38bb-cdd5-497f-9fa5-b6abb0a15d28")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("2d5a38bb-cdd5-497f-9fa5-b6abb0a15d28")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Cell240 item.
            /// </summary>
            [RepositoryItem("cbf02276-e9aa-40b1-9e4a-db35a94a2836")]
            public virtual Ranorex.Cell Cell240
            {
                get
                {
                    return _cell240Info.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The Cell240 item info.
            /// </summary>
            [RepositoryItemInfo("cbf02276-e9aa-40b1-9e4a-db35a94a2836")]
            public virtual RepoItemInfo Cell240Info
            {
                get
                {
                    return _cell240Info;
                }
            }

            /// <summary>
            /// The MBtnOK item.
            /// </summary>
            [RepositoryItem("f36f0f04-6571-4d07-8ab9-9a8a14993f83")]
            public virtual Ranorex.Button MBtnOK
            {
                get
                {
                    return _mbtnokInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The MBtnOK item info.
            /// </summary>
            [RepositoryItemInfo("f36f0f04-6571-4d07-8ab9-9a8a14993f83")]
            public virtual RepoItemInfo MBtnOKInfo
            {
                get
                {
                    return _mbtnokInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
