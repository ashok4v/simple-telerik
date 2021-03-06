﻿// (c) Copyright 2002-2010 Telerik 
// This source is subject to the GNU General Public License, version 2
// See http://www.gnu.org/licenses/gpl-2.0.html. 
// All other rights reserved.

namespace Telerik.Web.Mvc.UI
{
    using System.Globalization;
    using Telerik.Web.Mvc.Infrastructure;

    public class EditorLocalization : ViewComponentLocalization, IClientSerializable
    {
        public EditorLocalization()
            : this(null)
        {
        }

        public EditorLocalization(CultureInfo culture)
            : this(null, culture)
        {
        }

        public EditorLocalization(string resourceLocation, CultureInfo culture)
            : base(resourceLocation, "EditorLocalization", culture)
        {
        }

        public string Bold
        {
            get { return GetValue("Bold"); }
        }

        public string Italic
        {
            get { return GetValue("Italic"); }
        }

        public string Underline
        {
            get { return GetValue("Underline"); }
        }

        public string Strikethrough
        {
            get { return GetValue("Strikethrough"); }
        }

        public string JustifyCenter
        {
            get { return GetValue("JustifyCenter"); }
        }

        public string JustifyLeft
        {
            get { return GetValue("JustifyLeft"); }
        }

        public string JustifyRight
        {
            get { return GetValue("JustifyRight"); }
        }

        public string JustifyFull
        {
            get { return GetValue("JustifyFull"); }
        }

        public string InsertUnorderedList
        {
            get { return GetValue("InsertUnorderedList"); }
        }

        public string InsertOrderedList
        {
            get { return GetValue("InsertOrderedList"); }
        }

        public string Indent
        {
            get { return GetValue("Indent"); }
        }

        public string Outdent
        {
            get { return GetValue("Outdent"); }
        }

        public string CreateLink
        {
            get { return GetValue("CreateLink"); }
        }

        public string Unlink
        {
            get { return GetValue("Unlink"); }
        }

        public string InsertImage
        {
            get { return GetValue("InsertImage"); }
        }

        public string InsertHtml
        {
            get { return GetValue("InsertHtml"); }
        }

        public string FontName
        {
            get { return GetValue("FontName"); }
        }

        public string FontSize
        {
            get { return GetValue("FontSize"); }
        }

        public string FormatBlock
        {
            get { return GetValue("FormatBlock"); }
        }

        public string Style
        {
            get { return GetValue("Style"); }
        }

        public void SerializeTo(string key, IClientSideObjectWriter writer)
        {
            if (!IsDefault)
            {
                writer.AppendObject(key, ToJson());
            }
        }
    }
}