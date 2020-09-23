using System.Collections.Generic;

namespace SwipeItemCustomItemInListView.AppShell
{
    public sealed partial class MainPage
    {
        private readonly List<string> _list;

        public MainPage()
        {
            _list = new List<string> {"line 1", "line 2"};
            InitializeComponent();
        }
    }
}
