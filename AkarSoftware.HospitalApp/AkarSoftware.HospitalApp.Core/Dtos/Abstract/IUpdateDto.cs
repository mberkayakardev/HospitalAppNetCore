namespace AkarSoftware.HospitalApp.Core.Dtos.Abstract
{
    /// <summary>
    /// Update görevini üstlenecek DTO lar aslında bir dto dur. update dto ların base dto lardan farkı id değerini barındırmasıdır.
    /// Bu sebeple bu şekilde bir ayrıştırmaya gidilmiştir. 
    /// </summary>
    public interface IUpdateDto : IDto
    {
        public int Id { get; set; }
    }
}
