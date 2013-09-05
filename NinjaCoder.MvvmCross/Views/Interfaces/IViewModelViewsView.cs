﻿// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the IViewModelViewsView type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace NinjaCoder.MvvmCross.Views.Interfaces
{
    using System.Collections.Generic;

    using Presenters;

    using Scorchio.VisualStudio.Entities;

    /// <summary>
    ///  Defines the IViewModelOptionsView type.
    /// </summary>
    public interface IViewModelViewsView
    {
        /// <summary>
        /// Gets or sets the presenter.
        /// </summary>
        ViewModelViewsPresenter Presenter { get; set; }

        /// <summary>
        /// Gets or sets the name of the view model.
        /// </summary>
        string ViewModelName { get; set; }

        /// <summary>
        /// Gets the required templates.
        /// </summary>
        List<ItemTemplateInfo> RequiredTemplates { get; }

        /// <summary>
        /// Gets a value indicating whether [include unit tests].
        /// </summary>
        bool IncludeUnitTests { get; }

        /// <summary>
        /// Adds the template.
        /// </summary>
        /// <param name="itemTemplateInfo">The item template info.</param>
        void AddTemplate(ItemTemplateInfo itemTemplateInfo);
    }
}