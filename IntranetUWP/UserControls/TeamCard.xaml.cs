﻿using IntranetUWP.Models;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace IntranetUWP.UserControls
{
    public sealed partial class TeamCard : UserControl
    {


        public TeamsDTO Teams
        {
            get { return (TeamsDTO)GetValue(TeamsProperty); }
            set { SetValue(TeamsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Teams.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TeamsProperty =
            DependencyProperty.Register("Teams", typeof(TeamsDTO), typeof(TeamsDTO), new PropertyMetadata(null));


        public TeamCard()
        {
            this.InitializeComponent();
        }
    }
}
