namespace LibraryManager.Core.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public bool Active { get; set; }

        public void Delete()
        {
            Active = false;
        }
    }
}
