using KgyHoldingWebsite.Application.Dtos;
using KgyHoldingWebsite.Application.Interfaces;
using KgyHoldingWebsite.Data;
using KgyHoldingWebsite.Models;

namespace KgyHoldingWebsite.Application.Services
{
    public class BoardMemberService : IBoardMemberService
    {
        private readonly KgyDbContext _context;

        public BoardMemberService(KgyDbContext context)
        {
            _context = context;
        }

        public List<BoardMemberDto> GetAll()
        {
            return _context.BoardMembers
                .Select(b => new BoardMemberDto
                {
                    Id = b.Id,
                    FullName = b.FullName,
                    Role = b.Role,
                    ImageUrl = b.ImageUrl,
                    Description = b.Description
                })
                .ToList();
        }

        public BoardMemberDto? GetById(int id)
        {
            var member = _context.BoardMembers.Find(id);
            if (member == null) return null;

            return new BoardMemberDto
            {
                Id = member.Id,
                FullName = member.FullName,
                Role = member.Role,
                ImageUrl = member.ImageUrl,
                Description = member.Description
            };
        }

        public void Add(BoardMemberDto dto)
        {
            var entity = new BoardMember
            {
                FullName = dto.FullName,
                Role = dto.Role,
                ImageUrl = dto.ImageUrl,
                Description = dto.Description
            };

            _context.BoardMembers.Add(entity);
            _context.SaveChanges();
        }

        public bool Update(int id, BoardMemberDto dto)
        {
            var member = _context.BoardMembers.Find(id);
            if (member == null) return false;

            member.FullName = dto.FullName;
            member.Role = dto.Role;
            member.ImageUrl = dto.ImageUrl;
            member.Description = dto.Description;

            _context.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            var member = _context.BoardMembers.Find(id);
            if (member == null) return false;

            _context.BoardMembers.Remove(member);
            _context.SaveChanges();
            return true;
        }
    }
}

