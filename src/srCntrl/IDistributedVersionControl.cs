namespace srCntrl
{
    public interface IDistributedVersionControl
    {
        /// <summary>
        /// Update local branch with remote changes
        /// </summary>
        void UpdateLocal();
        
        /// <summary>
        /// Checkout a local branch
        /// </summary>
        void CheckoutBranch();
        
        /// <summary>
        /// Update remote repository hashes but don't pull updates in local branches
        /// </summary>
        void UpdateRemote();

        /// <summary>
        /// Pull remote changes into the local branch
        /// </summary>
        void Pull();

        /// <summary>
        /// Clone a repository
        /// </summary>
        void Clone();
    }
}