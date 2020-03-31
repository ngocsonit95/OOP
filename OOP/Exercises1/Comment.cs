using System;
using System.Collections.Generic;

namespace OOP.Exercises1
{
    public class Comment
    {
        // Fields
        private List<string> comment;

        /// <summary>
        /// Constructor Comment
        /// </summary>
        public Comment()
        {
            this.InputComment = new List<string>();
        }

        /// <summary>
        /// Properties InputComment
        /// </summary>
        public List<string> InputComment
        {
            get { return this.comment; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException($"Comment cannot be null!");
                }
                else
                {
                    this.comment = value;
                }
            }
        }

        //Methods AddComment
        public void AddComment(string addComment)
        {
            InputComment.Add(addComment);
        }
    }
}