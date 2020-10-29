﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorClassicForms.HTML;

namespace System.Drawing
{
    public class Font
    {
        public string FamilyName { get; }
        public float EmSize { get; }
        public FontStyle Style { get; } = FontStyle.Regular;
        public GraphicsUnit Unit { get; } = GraphicsUnit.Point;

        public static void SetFont(Font font, HTMLElement element)
        {
            if (font == null)
            {
                element.style.fontSize = "inherit";
                element.style.fontFamily = "inherit";
            }
            else
            {
                if(font.EmSize > 0)
                    element.style.fontSize = font.EmSize.ToString() + "pt";
                else
                    element.style.fontSize = "inherit";

                if (!string.IsNullOrWhiteSpace(font.FamilyName))
                    element.style.fontFamily = font.FamilyName;
                else
                    element.style.fontFamily = "inherit";
            }

        }

        public Font(string familyName, float emSize, FontStyle style, GraphicsUnit unit, byte gdiCharSet) : this(familyName, emSize)
        {
            Style = style;
        }

        public Font(string familyName, float emSize)
        {
            if (!Settings.WinFormIgnoreFontName)
                FamilyName = familyName;
            else
                FamilyName = Settings.WinFormIgnoreFontDefaultFontName;
            if (!Settings.WinFormIgnoreFontSize)
                EmSize = emSize;
            else
                EmSize = Settings.WinFormIgnoreFontDefaultSize;
        }

    }
}
