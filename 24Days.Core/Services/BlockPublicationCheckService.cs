using System;
using _24Days.Core.Ranges;
using _Days.Models.Content;
using Umbraco.Cms.Core.Models.Blocks;
using Umbraco.Extensions;

namespace _24Days.Core.Services
{
    internal class BlockPublicationCheckService : IBlockPublicationCheckService
    {
        public bool IsBlockPublished(BlockListItem block)
        {
            if (block == null)
            {
                return false;
            }

            if (block.Settings == null)
            {
                return true;
            }

            if (block.Settings.ContentType.Alias == PublicationRestrictions.ModelTypeAlias ||
                block.Settings.IsComposedOf(PublicationRestrictions.ModelTypeAlias))
            {
                var settings = (PublicationRestrictions)block.Settings;

                if (settings.HideBlock)
                {
                    return false;
                }

                var dateRange =
                    new DateRange(
                        settings.StartDate == default ? DateTime.MinValue : settings.StartDate,
                        settings.EndDate == default ? DateTime.MaxValue : settings.EndDate);

                return dateRange.Includes(DateTime.Now);
            }

            return true;
        }
    }
}
