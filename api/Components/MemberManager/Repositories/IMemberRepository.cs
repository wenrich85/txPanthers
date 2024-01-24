using TxPanthers.Api.Models;

namespace TxPanthers.Api.Repositories
{
    public interface IMemberRepository
    {
        public Task<List<MemberDetails>> GetMemberListAsync();
        public Task<MemberDetails> GetMemberByIdAsync(int Id);
        public Task<MemberDetails> AddMemberAsync(MemberDetails memberDetails);
        public Task<int> UpdateMemberAsync(MemberDetails memberDetails);
        public Task<int> DeleteMemberAsync(int Id);
    }
}