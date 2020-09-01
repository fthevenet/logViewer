using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Collections.Specialized;

namespace FTH.Utils.LogViewer
{
    public class StringHistory
    {
        private SortedList<int, string> history;
        private int maxDepth;
        private ToolStripComboBox linkedCbo;

        public int MaxDepth
        {
            get { return maxDepth; }
        }

        public int Capacity
        {
            get { return maxDepth; }
            set 
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Capacity", "Capacity cannot be equal to or less than 0");

                maxDepth = value; 
            }
        }

        public StringHistory() : this(10, null, null) { }

        public StringHistory(int maxDepth) : this(maxDepth, null, null) { }

        public StringHistory(int maxDepth, StringCollection initList) : this(maxDepth, null, initList) { }

        public StringHistory(int maxDepth, ToolStripComboBox linkedCbo, StringCollection initList)
        {
            this.maxDepth = maxDepth;
            this.history = new SortedList<int, string>(maxDepth, new ReverseComparer<int>(Comparer<int>.Default));

            if (linkedCbo != null)
            {
                this.linkedCbo = linkedCbo;
                this.linkedCbo.Validated += new EventHandler(linkedCbo_Validated);
            }

            if (initList != null)
                this.Load(initList);
        }

        public void Load(StringCollection list)
        {
            if (list == null)
                throw new ArgumentNullException("list");

            foreach (string s in list)
                this.Push(s);

        }

        public StringCollection Save()
        {
            StringCollection saveCol = new StringCollection();
            string[] strs = new string[history.Count];
            history.Values.CopyTo(strs, 0);
            saveCol.AddRange(strs);
            
            return saveCol;

        }

        

        public void Clear()
        {
            this.history.Clear();
        }

        public string Pop()
        {
            if (history.Count < 1)
                throw new IndexOutOfRangeException("Stack is empty");

            return history[0];
        }

        public void Push(string value)
        {
            if (string.IsNullOrEmpty(value))
                return;

            if (history.ContainsValue(value))
                history.RemoveAt(history.IndexOfValue(value));

            int nextKey = history.Count > 0 ? history.Keys[0] + 1 : 0;

            history.Add(nextKey, value);

            if (history.Values.Count > maxDepth)
                history.RemoveAt(history.Count - 1);

            if (nextKey >= int.MaxValue - 1)
                reIndexStack();

            if (linkedCbo != null)
                updateComboBox();

        }

        private void updateComboBox()
        {
            this.linkedCbo.Items.Clear();
            for (int i = 0; i < history.Count; i++)
                this.linkedCbo.Items.Add(history.Values[i]);
        }

        private void reIndexStack()
        {
            SortedList<int, string> newStack = new SortedList<int, string>(maxDepth, new ReverseComparer<int>(Comparer<int>.Default));

            for (int i=0;i<history.Count; i++)
                newStack.Add(history.Count - i, history[i]);

            history = newStack;
        }

        void linkedCbo_Validated(object sender, EventArgs e)
        {
            this.Push(this.linkedCbo.Text);
        }

    }


    public sealed class ReverseComparer<T> : IComparer<T>
    {
        readonly IComparer<T> originalComparer;

        public IComparer<T> OriginalComparer
        {
            get { return originalComparer; }
        }

        public ReverseComparer(IComparer<T> original)
        {
            if (original == null)
            {
                throw new ArgumentNullException("original");
            }
            this.originalComparer = original;
        }

        public int Compare(T x, T y)
        {
            return originalComparer.Compare(y, x);
        }
    }
 
}
