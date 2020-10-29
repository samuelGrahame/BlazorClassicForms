﻿using BlazorClassicForms.HTML;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace System.Windows.Forms
{
    public class PictureBox : Control, ISupportInitialize
    {
        public PictureBox() : base(new HTMLDivElement())
        {

        }

        private ImageLayout cBackgroundImageLayout = ImageLayout.None;
        public ImageLayout BackgroundImageLayout { get => cBackgroundImageLayout; set
            {
                Element.style.backgroundSize = null;
                Element.style.backgroundRepeat = "no-repeat";                
                Element.style.backgroundPosition = null;

                switch (value)
                {
                    case ImageLayout.None:
 
                        break;
                    case ImageLayout.Tile:
                        Element.style.backgroundRepeat = "repeat";
                        break;
                    case ImageLayout.Center:                        
                        Element.style.backgroundPosition = "center";
                        break;
                    case ImageLayout.Stretch:
                        Element.style.backgroundSize = "100% 100%";
                        break;
                    case ImageLayout.Zoom:    
                        Element.style.backgroundSize = "contain";
                        Element.style.backgroundPosition = "center";
                        break;
                    default:
                        break;
                }

            }
        }
               
        private Image cBackgroundImage;
        public Image BackgroundImage { get => cBackgroundImage; set => Element.style.backgroundImage = $"url('{(cBackgroundImage = value).Data}')"; }

        public void BeginInit()
        {
            
        }

        public void EndInit()
        {
            
        }
    }
}
