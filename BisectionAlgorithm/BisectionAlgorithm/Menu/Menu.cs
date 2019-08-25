using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BisectionAlgorithm
{
    public sealed class Menu : MenuItem
    {
        private Stack<MenuItem> navigator;

        private bool Showing { get; set; }

        private MenuItem CurrentMenu
        {
            get
            {
                return navigator.Peek();
            }
        }

        public MenuHorizontalAligment HorizontalAligment { get; set; }

        public bool CyclicScrolling { get; set; }

        public bool ShowNavigationBar { get; set; }

        public int SelectedIndex { get; set; }

        public Menu()
            : this("Zachary R. Herrera<")
        { }

        public Menu(string title)
            : base(title)
        {
            navigator = new Stack<MenuItem>();
            navigator.Push(this);
        }

        private void DrawMenu()
        {
            Console.Clear();

            if (ShowNavigationBar)
            {
                DrawLine(GetPath());
                DrawLine(string.Empty);
            }

            for (int i = 0; i < CurrentMenu.Count; i++)
            {
                if (i == SelectedIndex)
                {
                    InvertColors();
                    DrawLine(CurrentMenu[i].ToString());
                    InvertColors();
                }
                else
                {
                    DrawLine(CurrentMenu[i].ToString());
                }
            }
        }

        private void DrawLine(string text)
        {
            int start = 0;
            if (HorizontalAligment == MenuHorizontalAligment.Right)
                start = Console.WindowWidth - text.Length - 1;
            else if (HorizontalAligment == MenuHorizontalAligment.Center)
                start = (Console.WindowWidth - text.Length) / 2;
            Console.CursorLeft = start;
            WriteText.WriteLine(text);
        }

        private string GetPath()
        {
            string path = string.Empty;
            foreach (var item in navigator.Reverse())
            {
                path += item.Title + ">";
            }
            return path;
        }

        private void InvertColors()
        {
            var tmp = Console.BackgroundColor;
            Console.BackgroundColor = Console.ForegroundColor;
            Console.ForegroundColor = tmp;
        }

        public void Show()
        {
            Showing = true;

            while (Showing)
            {
                DrawMenu();
                var key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        MoveSelection(-1);
                        break;

                    case ConsoleKey.DownArrow:
                        MoveSelection(1);
                        break;

                    case ConsoleKey.RightArrow:
                    case ConsoleKey.Enter:
                        var mi = CurrentMenu[SelectedIndex];
                        if (mi.Count == 0)
                            Hide();
                        mi.PerformAction();
                        if (mi.Count > 0)
                        {
                            navigator.Push(mi);
                            SelectedIndex = 0;
                        }
                        break;

                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.Escape:
                        NavigateBack();
                        break;
                    default:
                        break;
                }
            }
        }

        private void MoveSelection(int count)
        {
            if (CyclicScrolling)
            {
                SelectedIndex = (CurrentMenu.Count + SelectedIndex + count) % CurrentMenu.Count;
            }
            else
            {
                int newIdex = SelectedIndex + count;
                SelectedIndex = Math.Max(0, (Math.Min(newIdex, CurrentMenu.Count - 1)));
            }
        }

        private void NavigateBack()
        {
            if (navigator.Count == 1)
                Hide();
            else
                navigator.Pop();
        }

        public void Hide()
        {
            Showing = false;
            Console.Clear();
        }
    }
}

