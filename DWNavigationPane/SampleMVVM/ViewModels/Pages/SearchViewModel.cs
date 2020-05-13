using DWNavigationPane;
using SampleMVVM.DataTypes;
using SampleMVVM.Helpers;
using SampleMVVM.Models;
using System;

namespace SampleMVVM.ViewModels
{
    internal class SearchViewModel : PropertyChangedBase, IPage
    {
        public string DisplayName => "Search";

        /// <summary>
        /// For Design-time support
        /// </summary>
        public SearchViewModel()
        {
        }

        private INavigator Navigator { get; }

        public SearchViewModel(INavigator navigator)
        {
            Navigator = navigator;
        }
    }
}