using System.Collections.Generic;

namespace DesignAStack
{
    class Stack
    {

        private readonly List<object> stack = new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
                throw new System.InvalidOperationException("Cannot store a null object");
            stack.Add(obj);
        }

        public object Pop()
        {
            if (stack.Count == 0)
                throw new System.InvalidOperationException("No items in the stack to pop");
            object topObject = stack[stack.Count - 1];
            stack.RemoveAt(stack.Count - 1);
            return topObject;
        }

        public void Clear()
        {
            stack.RemoveRange(0,stack.Count - 1);
        }
    }
}
