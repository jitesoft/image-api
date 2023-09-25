namespace Lib.Queue;

/// <summary>
/// Queue Interface.
/// </summary>
public interface IQueueService
{
    /// <summary>
    /// Enqueue a message to the end of the queue.
    /// </summary>
    /// <param name="message">Message to enqueue.</param>
    /// <returns>Completed task.</returns>
    public Task Enqueue(IMessage message);

    /// <summary>
    /// Dequeue a message from the top of the queue.
    /// </summary>
    /// <returns>Message.</returns>
    public Task<IMessage> Dequeue();

    /// <summary>
    /// Get number of messages currently queued.
    /// </summary>
    /// <returns>Number of messages in queue.</returns>
    public Task<int> Count();
}
