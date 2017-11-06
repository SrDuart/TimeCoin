using System.ServiceModel;
using Biblioteca.ClassesBasicas;
using System.Collections.Generic;
namespace WcfService
{
    [ServiceContract]
    public interface IService1
    {
        //TipoUsuario
        #region TipoUsuario
        [OperationContract]
        void TipoUsuarioInsert(TipoUsuario tipoUsuario);

        [OperationContract]
        void TipoUsuarioUpdate(TipoUsuario tipoUsuario);

        [OperationContract]
        void TipoUsuarioDelete(TipoUsuario tipoUsuario);

        [OperationContract]
        List<TipoUsuario> TipoUsuarioSelect(TipoUsuario filtro);

        [OperationContract]
        bool TipoUsuarioVerificaDuplicidade(TipoUsuario filtro);
        #endregion

        //Situacao
        #region Situacao
        [OperationContract]
        void SituacaoInsert(Situacao situacao);

        [OperationContract]
        void SituacaoUpdate(Situacao situacao);

        [OperationContract]
        void SituacaoDelete(Situacao situacao);

        [OperationContract]
        List<Situacao> SituacaoSelect(Situacao filtro);

        //[OperationContract]
        //bool SituacaoVerificaDuplicidade(Situacao situacao);
        #endregion

        //Usuario
        #region Usuario
        [OperationContract]
        void UsuarioInsert(Usuario usuario);

        [OperationContract]
        void UsuarioUpdate(Usuario usuario);

        [OperationContract]
        void UsuarioDelete(Usuario usuario);

        [OperationContract]
        List<Usuario> UsuarioSelect(Usuario filtro);

        //[OperationContract]
        //bool UsuarioVerificaDuplicidade(Usuario usuario);
        #endregion

        //Servico
        #region Servico
        [OperationContract]
        void ServicoInsert(Servico servico);

        [OperationContract]
        void ServicoUpdate(Servico servico);

        [OperationContract]
        void ServicoDelete(Servico servico);

        [OperationContract]
        List<Servico> ServicoSelect(Servico filtro);

        //[OperationContract]
        //bool ServicoVerificaDuplicidade(Servico servico);
        #endregion

        //Atividade
        #region Atividade
        [OperationContract]
        void AtividadeInsert(Atividade atividade);

        [OperationContract]
        void AtividadeUpdate(Atividade atividade);

        [OperationContract]
        void AtividadeDelete(Atividade atividade);

        [OperationContract]
        List<Atividade> AtividadeSelect(Atividade atividade);

        [OperationContract]
        bool AtividadeVerificaDuplicidade(Atividade atividade);
        #endregion

        //Presta
        #region Presta
        [OperationContract]
        void PrestaInsert(Presta presta);

        [OperationContract]
        void PrestaUpdate(Presta presta);

        [OperationContract]
        void PrestaDelete(Presta presta);

        [OperationContract]
        List<Presta> PrestaSelect(Presta presta);

        [OperationContract]
        bool PrestaVerificaDuplicidade(Presta presta);
        #endregion

        //Recebe
        #region Recebe
        [OperationContract]
        void RecebeInsert(Recebe recebe);

        [OperationContract]
        void RecebeUpdate(Recebe recebe);

        [OperationContract]
        void RecebeDelete(Recebe recebe);

        [OperationContract]
        List<Recebe> RecebeSelect(Recebe recebe);

        [OperationContract]
        bool RecebeVerificaDuplicidade(Recebe recebe);
        #endregion       
    }
}
