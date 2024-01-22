namespace TxPanthers.Api.Services;

using TxPanthers.Api.Models;
using TxPanthers.Api.Data;

public interface IMemberService
{
    IEnumerable<MemberDetails> GetAll();
}

public class MemberService : IMemberService 
{
    private DataContext _context;

    public MemberService(DataContext context)
    {
        _context = context;
    }

    public IEnumerable<MemberDetails> GetAll()
    {
        return _context.Members;
    }
}