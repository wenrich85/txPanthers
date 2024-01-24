using TxPanthers.Api.Models;
using TxPanthers.Api.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Numerics;

namespace TxPanthers.Api.Repositories
{
    public class MemberRepository: IMemberRepository
    {
        private readonly DataContext _dbContext;

        public MemberRepository(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<MemberDetails> AddMemberAsync(MemberDetails memberDetails)
        {
            var result = _dbContext.Members.Add(memberDetails);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<int> DeleteMemberAsync(int Id)
        {
            var filterData = _dbContext.Members.Where(x => x.Id == Id).FirstOrDefault();
            _dbContext.Members.Remove(filterData);
            return await _dbContext.SaveChangesAsync();
        }
        public async Task<MemberDetails> GetMemberByIdAsync(int Id)
        {
            return await _dbContext.Members.Where(x => x.Id == Id).FirstOrDefaultAsync();
        }

        public async Task<List<MemberDetails>> GetMemberListAsync()
        {
            return await _dbContext.Members.ToListAsync();
        }

        public async Task<int> UpdateMemberAsync(MemberDetails memberDetails)
        {
            _dbContext.Members.Update(memberDetails);
            return await _dbContext.SaveChangesAsync();
        }
    }
}