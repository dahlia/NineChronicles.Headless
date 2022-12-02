using Libplanet.Action;
using Libplanet.Blockchain;
using Libplanet.Explorer.Interfaces;
using Libplanet.Store;
using Nekoyume.Action;
using NCAction = Libplanet.Action.PolymorphicAction<Nekoyume.Action.ActionBase>;

namespace NineChronicles.Headless
{
    public class BlockChainContext : IBlockChainContext<NCAction>
    {
        private readonly StandaloneContext _standaloneContext;

        public BlockChainContext(StandaloneContext standaloneContext)
        {
            _standaloneContext = standaloneContext;
        }

        public bool Preloaded => _standaloneContext.PreloadEnded;
        public BlockChain<PolymorphicAction<ActionBase>>? BlockChain => _standaloneContext.BlockChain;
        public IStore? Store => _standaloneContext.Store;
    }
}
