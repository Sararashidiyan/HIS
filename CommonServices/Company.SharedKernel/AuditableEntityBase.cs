namespace Company.SharedKernel
{
    public abstract class AuditableEntityBase<T> : Auditable
    {
        public T Id { get; set; }
    }
}
