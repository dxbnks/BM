﻿#pragma checksum "..\..\Songs.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B3A5EEBC0C482BE51D625DED1514A19C9E69F78535D0514E0F7F137AA40A277C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using BMBF_Manager;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace BMBF_Manager {
    
    
    /// <summary>
    /// Songs
    /// </summary>
    public partial class Songs : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\Songs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Quest;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\Songs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtbox;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\Songs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SongKey;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\Songs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView SongList;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\Songs.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchTerm;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/BMBF Manager;component/songs.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Songs.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 10 "..\..\Songs.xaml"
            ((BMBF_Manager.Songs)(target)).MouseMove += new System.Windows.Input.MouseEventHandler(this.Drag);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 16 "..\..\Songs.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.noDrag);
            
            #line default
            #line hidden
            
            #line 16 "..\..\Songs.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.doDrag);
            
            #line default
            #line hidden
            
            #line 16 "..\..\Songs.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Close);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 17 "..\..\Songs.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.noDrag);
            
            #line default
            #line hidden
            
            #line 17 "..\..\Songs.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.doDrag);
            
            #line default
            #line hidden
            
            #line 17 "..\..\Songs.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Mini);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Quest = ((System.Windows.Controls.TextBox)(target));
            
            #line 27 "..\..\Songs.xaml"
            this.Quest.LostFocus += new System.Windows.RoutedEventHandler(this.QuestIPCheck);
            
            #line default
            #line hidden
            
            #line 27 "..\..\Songs.xaml"
            this.Quest.GotFocus += new System.Windows.RoutedEventHandler(this.ClearText);
            
            #line default
            #line hidden
            
            #line 27 "..\..\Songs.xaml"
            this.Quest.MouseEnter += new System.Windows.Input.MouseEventHandler(this.noDrag);
            
            #line default
            #line hidden
            
            #line 27 "..\..\Songs.xaml"
            this.Quest.MouseLeave += new System.Windows.Input.MouseEventHandler(this.doDrag);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtbox = ((System.Windows.Controls.TextBox)(target));
            
            #line 29 "..\..\Songs.xaml"
            this.txtbox.MouseEnter += new System.Windows.Input.MouseEventHandler(this.noDrag);
            
            #line default
            #line hidden
            
            #line 29 "..\..\Songs.xaml"
            this.txtbox.MouseLeave += new System.Windows.Input.MouseEventHandler(this.doDrag);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 30 "..\..\Songs.xaml"
            ((System.Windows.Controls.AccessText)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.noDrag);
            
            #line default
            #line hidden
            
            #line 30 "..\..\Songs.xaml"
            ((System.Windows.Controls.AccessText)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.doDrag);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 31 "..\..\Songs.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.noDrag);
            
            #line default
            #line hidden
            
            #line 31 "..\..\Songs.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.doDrag);
            
            #line default
            #line hidden
            
            #line 31 "..\..\Songs.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LoadSongData);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 32 "..\..\Songs.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.noDrag);
            
            #line default
            #line hidden
            
            #line 32 "..\..\Songs.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.doDrag);
            
            #line default
            #line hidden
            
            #line 32 "..\..\Songs.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.InstallSong);
            
            #line default
            #line hidden
            return;
            case 9:
            this.SongKey = ((System.Windows.Controls.TextBox)(target));
            
            #line 33 "..\..\Songs.xaml"
            this.SongKey.LostFocus += new System.Windows.RoutedEventHandler(this.SongKeyCheck);
            
            #line default
            #line hidden
            
            #line 33 "..\..\Songs.xaml"
            this.SongKey.GotFocus += new System.Windows.RoutedEventHandler(this.ClearKey);
            
            #line default
            #line hidden
            
            #line 33 "..\..\Songs.xaml"
            this.SongKey.MouseEnter += new System.Windows.Input.MouseEventHandler(this.noDrag);
            
            #line default
            #line hidden
            
            #line 33 "..\..\Songs.xaml"
            this.SongKey.MouseLeave += new System.Windows.Input.MouseEventHandler(this.doDrag);
            
            #line default
            #line hidden
            return;
            case 10:
            this.SongList = ((System.Windows.Controls.ListView)(target));
            
            #line 34 "..\..\Songs.xaml"
            this.SongList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SelectionChanged);
            
            #line default
            #line hidden
            
            #line 34 "..\..\Songs.xaml"
            this.SongList.MouseEnter += new System.Windows.Input.MouseEventHandler(this.noDrag);
            
            #line default
            #line hidden
            
            #line 34 "..\..\Songs.xaml"
            this.SongList.MouseLeave += new System.Windows.Input.MouseEventHandler(this.doDrag);
            
            #line default
            #line hidden
            return;
            case 11:
            this.SearchTerm = ((System.Windows.Controls.TextBox)(target));
            
            #line 55 "..\..\Songs.xaml"
            this.SearchTerm.LostFocus += new System.Windows.RoutedEventHandler(this.SearchTermCheck);
            
            #line default
            #line hidden
            
            #line 55 "..\..\Songs.xaml"
            this.SearchTerm.GotFocus += new System.Windows.RoutedEventHandler(this.ClearSearch);
            
            #line default
            #line hidden
            
            #line 55 "..\..\Songs.xaml"
            this.SearchTerm.MouseEnter += new System.Windows.Input.MouseEventHandler(this.noDrag);
            
            #line default
            #line hidden
            
            #line 55 "..\..\Songs.xaml"
            this.SearchTerm.MouseLeave += new System.Windows.Input.MouseEventHandler(this.doDrag);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 56 "..\..\Songs.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.noDrag);
            
            #line default
            #line hidden
            
            #line 56 "..\..\Songs.xaml"
            ((System.Windows.Controls.Button)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.doDrag);
            
            #line default
            #line hidden
            
            #line 56 "..\..\Songs.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Search);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

