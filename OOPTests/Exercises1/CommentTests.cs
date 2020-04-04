using Xunit;

namespace OOP.Exercises1.Tests
{
    public class CommentTests
    {
        [Fact]
        public void Contructor_CreateObjectNotNull_CommentTest()
        {
            var comment = new Comment();
            Assert.NotNull(comment);
        }

        [Fact]
        public void Properties_CreateObjectNotNull_InputCommentTest()
        {
            var comment = new Comment();
            var actualInputComment = comment.InputComment;
            Assert.NotNull(actualInputComment);
        }

        [Fact]
        public void Method_CreateObjectNotNull_AddCommentTest()
        {
            var comment = new Comment();
            comment.AddComment("comment");
            Assert.NotNull("comment");
        }
    }
}