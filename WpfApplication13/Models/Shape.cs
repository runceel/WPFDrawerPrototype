using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication13.Models
{
    class Shape : BindableBase
    {
        private int layer;

        public int Layer
        {
            get { return this.layer; }
            set { this.SetProperty(ref this.layer, value); }
        }

    }

    class Area : Shape
    {
        private int top;

        public int Top
        {
            get { return this.top; }
            set { this.SetProperty(ref this.top, value); }
        }

        private int left;

        public int Left
        {
            get { return this.left; }
            set { this.SetProperty(ref this.left, value); }
        }

        private int width;

        public int Width
        {
            get { return this.width; }
            set { this.SetProperty(ref this.width, value); }
        }

        private int height;

        public int Height
        {
            get { return this.height; }
            set { this.SetProperty(ref this.height, value); }
        }

    }

    class Postit : Area
    {
        private string text;

        public string Text
        {
            get { return this.text; }
            set { this.SetProperty(ref this.text, value); }
        }
    }

    class Connector : Shape
    {
        private Area area1;

        public Area Area1
        {
            get { return this.area1; }
            set { this.SetProperty(ref this.area1, value); }
        }

        private Area area2;

        public Area Area2
        {
            get { return this.area2; }
            set { this.SetProperty(ref this.area2, value); }
        }

        public int X1
        {
            get { return this.Area1.Left + this.Area1.Width / 2; }
        }

        public int Y1
        {
            get { return this.Area1.Top + this.Area1.Height / 2; }
        }
        public int X2
        {
            get { return this.Area2.Left + this.Area2.Width / 2; }
        }

        public int Y2
        {
            get { return this.Area2.Top + this.Area2.Height / 2; }
        }

        public Connector()
        {
            this.Layer = -1;
        }
    }
}
