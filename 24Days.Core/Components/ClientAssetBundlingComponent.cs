using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.WebAssets;

namespace _24Days.Core.Components
{
    internal class ClientAssetBundlingComponent : IComponent
    {
        private readonly IRuntimeMinifier _runtimeMinifier;

        public ClientAssetBundlingComponent(IRuntimeMinifier runtimeMinifier)
        {
            _runtimeMinifier = runtimeMinifier;
        }

        public void Initialize()
        {
            _runtimeMinifier.CreateCssBundle("css-bundle",
                BundlingOptions.NotOptimizedAndComposite, "~/assets/styles.css");
        }

        public void Terminate()
        {
        }
    }
}
