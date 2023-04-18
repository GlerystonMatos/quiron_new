﻿using Quiron.Domain.Dto;
using Quiron.Domain.Interfaces.Base;

namespace Quiron.Domain.Interfaces.Services
{
    public interface IUsuarioService : IService<UsuarioDto>
    {
        UsuarioDto ObterUsuarioParaAutenticacao(LoginDto login);
    }
}