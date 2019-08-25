using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BisectionAlgorithm
{
    public class MenuItem : IEnumerable<MenuItem>
    {
        private Action Action { get; set; }

        private List<MenuItem> Items { get; }

        public string Title { get; private set; }

        public int Count => Items.Count;

        public MenuItem this[string title]
        {
            get
            {
                var item = Items.Find(m => m.Title == title);
                return item ?? throw new ArgumentException($"Menu doesn't contain item '{title}'", nameof(title));
            }
        }

        public MenuItem this[int index]
        {
            get
            {
                return Items[index];
            }
        }

        public MenuItem(string title, Action action)
        {
            Title = title ?? throw new ArgumentNullException(nameof(title));
            this.Action = action;
            Items = new List<MenuItem>();
        }

        public MenuItem(string title)
            : this(title, null)
        {

        }

        public void Add(MenuItem item)
        {
            Items.Add(item);
        }

        public void Insert(int index, MenuItem item)
        {
            Items.Insert(index, item);
        }

        public void Remove(MenuItem item)
        {
            Items.Remove(item);
        }

        public void RemoveAt(int index)
        {
            Items.RemoveAt(index);
        }

        public void PerformAction()
        {
            Action?.Invoke();
        }

        public IEnumerator<MenuItem> GetEnumerator()
        {
            return Items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override string ToString()
        {
            return Items.Count > 0 ? Title + ">" : Title;
        }
    }
}
