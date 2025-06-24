using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KgyHoldingWebsite.Application.Dtos;

namespace KgyHoldingWebsite.Application.Interfaces
{
    public interface IBoardMemberService
    {
        List<BoardMemberDto> GetAll();
        BoardMemberDto? GetById(int id);
        void Add(BoardMemberDto dto);
        bool Update(int id, BoardMemberDto dto);
        bool Delete(int id);
    }
}
