namespace Utilities.Core.UtilityApplication.Abstractions.Excel
{
    public interface IExcelService
    {
        void WriteDataToExcel<T>(List<T> data, string filePath);
    }
}
