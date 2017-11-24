using Biblioteca.ClassesBasicas;
using Biblioteca.RegraNegocio;
using System.Collections.Generic;
using System;

namespace WcfService
{    
    public class Service1 : IService1
    {
        //TipoUsuário
        #region TipoUsuario
        public void TipoUsuarioInsert(TipoUsuario tipoUsuario)
        {
            TipoUsuarioRN regra = new TipoUsuarioRN();
            regra.Insert(tipoUsuario);
        }

        public void TipoUsuarioUpdate(TipoUsuario tipoUsuario)
        {
            TipoUsuarioRN regra = new TipoUsuarioRN();
            regra.Update(tipoUsuario);
        }

        public void TipoUsuarioDelete(TipoUsuario tipoUsuario)
        {
            TipoUsuarioRN regra = new TipoUsuarioRN();
            regra.Delete(tipoUsuario);
        }

        public List<TipoUsuario> TipoUsuarioSelect()
        {
            TipoUsuarioRN regra = new TipoUsuarioRN();
            return regra.Select();
        }

        public bool TipoUsuarioVerificaDuplicidade(TipoUsuario filtro)
        {
            TipoUsuarioRN regra = new TipoUsuarioRN();
            return regra.VerificaDuplicidade(filtro);
        }

        public bool TipoUsuarioVerificaExistencia(TipoUsuario filtro)
        {
            TipoUsuarioRN regra = new TipoUsuarioRN();
            return regra.VerificaExistencia(filtro);
        }
        #endregion

        //Situação
        #region Situacao
        public void SituacaoInsert(Situacao situacao)
        {
            SituacaoRN regra = new SituacaoRN();
            regra.Insert(situacao);
        }

        public void SituacaoUpdate(Situacao situacao)
        {
            SituacaoRN regra = new SituacaoRN();
            regra.Update(situacao);
        }

        public void SituacaoDelete(Situacao situacao)
        {
            SituacaoRN regra = new SituacaoRN();
            regra.Delete(situacao);
        }

        public List<Situacao> SituacaoSelect(Situacao filtro)
        {
            SituacaoRN regra = new SituacaoRN();
            return regra.Select(filtro);
        }

        public bool SituacaoVerificaDuplicidade(Situacao situacao)
        {
            SituacaoRN regra = new SituacaoRN();
            return regra.VerificaDuplicidade(situacao);
        }
        #endregion

        //Usuário
        #region Usuario
        public void UsuarioInsert(Usuario usuario)
        {
            UsuarioRN regra = new UsuarioRN();
            regra.Insert(usuario);
        }

        public void UsuarioUpdate(Usuario usuario)
        {
            UsuarioRN regra = new UsuarioRN();
            regra.Update(usuario);
        }

        public void UsuarioDelete(Usuario usuario)
        {
            UsuarioRN regra = new UsuarioRN();
            regra.Delete(usuario);
        }

        public void UsuarioVerificaLogin(Usuario usuario)
        {
            UsuarioRN regra = new UsuarioRN();
            regra.VerificaLogin(usuario);
        }

        public List<Usuario> UsuarioSelect(Usuario filtro)
        {
            UsuarioRN regra = new UsuarioRN();
            return regra.Select(filtro);
        }

        public bool UsuarioVerificaDuplicidade(Usuario usuario)
        {
            UsuarioRN regra = new UsuarioRN();
            return regra.VerificaDuplicidade(usuario);
        }
        #endregion

        //Serviço
        #region Servico
        public void ServicoInsert(Servico servico)
        {
            ServicoRN regra = new ServicoRN();
            regra.Insert(servico);
        }

        public void ServicoUpdate(Servico servico)
        {
            ServicoRN regra = new ServicoRN();
            regra.Update(servico);
        }

        public void ServicoDelete(Servico servico)
        {
            ServicoRN regra = new ServicoRN();
            regra.Delete(servico);
        }

        public List<Servico> ServicoSelect(Servico filtro)
        {
            ServicoRN regra = new ServicoRN();
            return regra.Select(filtro);
        }

        public bool ServicoVerificaDuplicidade(Servico servico)
        {
            ServicoRN regra = new ServicoRN();
            return regra.VerificaDuplicidade(servico);
        }
        #endregion

        //Habilidade
        #region Habilidade
        public void HabilidadeInsert(Habilidade habilidade)
        {
            HabilidadeRN regra = new HabilidadeRN();
            regra.Insert(habilidade);
        }

        public void HabilidadeUpdate(Habilidade habilidade)
        {
            HabilidadeRN regra = new HabilidadeRN();
            regra.Update(habilidade);
        }

        public void HabilidadeDelete(Habilidade habilidade)
        {
            HabilidadeRN regra = new HabilidadeRN();
            regra.Delete(habilidade);
        }

        public List<Habilidade> HabilidadeSelect(Habilidade filtro)
        {
            HabilidadeRN regra = new HabilidadeRN();
            return regra.Select(filtro);
        }

        public bool HabilidadeVerificaDuplicidade(Habilidade filtro)
        {
            HabilidadeRN regra = new HabilidadeRN();
            return regra.VerificaDuplicidade(filtro);
        }
        #endregion

        //UsuarioHabilidade
        #region UsuarioHabilidade
        public void UsuarioHabilidadeInsert(UsuarioHabilidade usuariohabilidade)
        {
            UsuarioHabilidadeRN regra = new UsuarioHabilidadeRN();
            regra.Insert(usuariohabilidade);
        }

        public void UsuarioHabilidadeUpdate(UsuarioHabilidade usuariohabilidade)
        {
            UsuarioHabilidadeRN regra = new UsuarioHabilidadeRN();
            regra.Update(usuariohabilidade);
        }

        public void UsuarioHabilidadeDelete(UsuarioHabilidade usuariohabilidade)
        {
            UsuarioHabilidadeRN regra = new UsuarioHabilidadeRN();
            regra.Delete(usuariohabilidade);
        }

        public List<UsuarioHabilidade> UsuarioHabilidadeSelect()
        {
            UsuarioHabilidadeRN regra = new UsuarioHabilidadeRN();
            return regra.Select();
        }

        public bool UsuarioHabilidadeVerificaDuplicidade(UsuarioHabilidade filtro)
        {
            UsuarioHabilidadeRN regra = new UsuarioHabilidadeRN();
            return regra.VerificaDuplicidade(filtro);
        }
        #endregion

        //Presta
        #region Presta
        public void PrestaInsert(Presta presta)
        {
            PrestaRN regra = new PrestaRN();
            regra.Insert(presta);
        }
        
        public void PrestaDelete(Presta presta)
        {
            PrestaRN regra = new PrestaRN();
            regra.Delete(presta);
        }

        public List<Presta> PrestaSelect(Presta filtro)
        {
            PrestaRN regra = new PrestaRN();
            return regra.Select(filtro);
        }        
        #endregion

        //Recebe
        #region Recebe
        public void RecebeInsert(Recebe recebe)
        {
            RecebeRN regra = new RecebeRN();
            regra.Insert(recebe);
        }        

        public void RecebeDelete(Recebe recebe)
        {
            RecebeRN regra = new RecebeRN();
            regra.Delete(recebe);
        }

        public List<Recebe> RecebeSelect(Recebe filtro)
        {
            RecebeRN regra = new RecebeRN();
            return regra.Select(filtro);
        }             
        #endregion

        //Anuncio
        #region Anuncio
        public void AnuncioInsert(Anuncio anuncio)
        {
            AnuncioRN regra = new AnuncioRN();
            regra.Insert(anuncio);
        }

        public void AnuncioUpdate(Anuncio anuncio)
        {
            AnuncioRN regra = new AnuncioRN();
            regra.Update(anuncio);
        }

        public void AnuncioDelete(Anuncio anuncio)
        {
            AnuncioRN regra = new AnuncioRN();
            regra.Delete(anuncio);
        }

        public List<Anuncio> AnuncioSelect()
        {
            AnuncioRN regra = new AnuncioRN();
            return regra.Select();
        }

        public bool AnuncioVerificaDuplicidade(Anuncio anuncio)
        {
            AnuncioRN regra = new AnuncioRN();
            return regra.VerificaDuplicidade(anuncio);
        }
        #endregion

        //TipoAnuncio
        #region TipoAnuncio
        public void TipoAnuncioInsert(TipoAnuncio tipoAnuncio)
        {
            TipoAnuncioRN regra = new TipoAnuncioRN();
            regra.Insert(tipoAnuncio);
        }

        public void TipoAnuncioUpdate(TipoAnuncio tipoAnuncio)
        {
            TipoAnuncioRN regra = new TipoAnuncioRN();
            regra.Update(tipoAnuncio);
        }

        public void TipoAnuncioDelete(TipoAnuncio tipoAnuncio)
        {
            TipoAnuncioRN regra = new TipoAnuncioRN();
            regra.Delete(tipoAnuncio);
        }

        public List<TipoAnuncio> TipoAnuncioSelect()
        {
            TipoAnuncioRN regra = new TipoAnuncioRN();
            return regra.Select();
        }

        public bool TipoAnuncioVerificaDuplicidade(TipoAnuncio tipoAnuncio)
        {
            TipoAnuncioRN regra = new TipoAnuncioRN();
            return regra.VerificaDuplicidade(tipoAnuncio);
        }
        #endregion
    }
}