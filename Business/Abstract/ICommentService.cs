using Entity.Concrate;

namespace Business.Abstract;

public interface ICommentService : IGenericService<Comment>
{
    List<Comment> TGetDestinationById(int id);
}
