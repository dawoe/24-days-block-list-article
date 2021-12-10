using Umbraco.Cms.Core.Models.Blocks;

namespace _24Days.Core.Services
{
    /// <summary>
    /// Represents a service to check if a content block is published.
    /// </summary>
    public interface IBlockPublicationCheckService
    {
        /// <summary>
        /// Checks if block is published.
        /// </summary>
        /// <param name="block">A <see cref="BlockListItem{T}"/>.</param>
        /// <returns>A value indicating whether the block is published.</returns>
        bool IsBlockPublished(BlockListItem block);
    }
}
