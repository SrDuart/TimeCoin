using Biblioteca.ClassesBasicas;
using Biblioteca.RegraNegocio;
using System.Collections.Generic;

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

        public List<TipoUsuario> TipoUsuarioSelect(TipoUsuario filtro)
        {
            TipoUsuarioRN regra = new TipoUsuarioRN();
            return regra.Select(filtro);
        }

        public bool TipoUsuarioVerificaDuplicidade(TipoUsuario filtro)
        {
            TipoUsuarioRN regra = new TipoUsuarioRN();
            return regra.VerificaDuplicidade(filtro);
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

        //bool SituacaoVerificaDuplicidade(Situacao tipoUsuario);
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

        public List<Usuario> UsuarioSelect(Usuario filtro)
        {
            UsuarioRN regra = new UsuarioRN();
            return regra.Select(filtro);
        }

        //bool UsuarioVerificaDuplicidade(Usuario usuario);
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

        //bool ServicoVerificaDuplicidade(Servico servico);
        #endregion

        //Atividade
        #region Atividade
        public void AtividadeInsert(Atividade atividade)
        {
            AtividadeRN regra = new AtividadeRN();
            regra.Insert(atividade);
        }

        public void AtividadeUpdate(Atividade atividade)
        {
            AtividadeRN regra = new AtividadeRN();
            regra.Update(atividade);
        }

        public void AtividadeDelete(Atividade atividade)
        {
            AtividadeRN regra = new AtividadeRN();
            regra.Delete(atividade);
        }

        public List<Atividade> AtividadeSelect(Atividade filtro)
        {
            AtividadeRN regra = new AtividadeRN();
            return regra.Select(filtro);
        }

        //bool AtividadeVerificaDuplicidade(Atividade atividade);
        #endregion

        //Presta
        #region Presta
        public void PrestaInsert(Presta presta)
        {
            PrestaRN regra = new PrestaRN();
            regra.Insert(presta);
        }

        public void PrestaUpdate(Presta presta)
        {
            PrestaRN regra = new PrestaRN();
            regra.Update(presta);
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

        //bool PrestaVerificaDuplicidade(Presta presta);
        #endregion

        //Recebe
        #region Recebe
        public void RecebeInsert(Recebe recebe)
        {
            RecebeRN regra = new RecebeRN();
            regra.Insert(recebe);
        }

        public void RecebeUpdate(Recebe recebe)
        {
            RecebeRN regra = new RecebeRN();
            regra.Update(recebe);
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

        //bool RecebeVerificaDuplicidade(Recebe recebe);
        #endregion  
    }
}
