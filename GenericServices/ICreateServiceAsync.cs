using System.Threading.Tasks;

namespace GenericServices
{
    public interface ICreateServiceAsync
    {
        /// <summary>
        /// This adds a new entity class to the database with error checking
        /// </summary>
        /// <typeparam name="T">The type of the data to output. 
        /// Type must be a type either an EF data class or one of the EfGenericDto's</typeparam>
        /// <param name="newItem">either entity class or dto to create the data item with</param>
        /// <returns>status</returns>
        Task<ISuccessOrErrors> CreateAsync<T>(T newItem) where T : class;
    }
}