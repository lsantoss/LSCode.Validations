using System.Collections.Generic;
using System.Linq;

namespace LSCode.Validations.NotifiableValidations
{
    /// <summary>Helps in managing notifications.</summary>
    public class Notifier
    {
        /// <value>Indicates if it is valid.</value>
        public bool Valid { get; private set; }

        /// <value>Indicates if it is invalid.</value>
        public bool Invalid { get; private set; }

        /// <value>List of notifications.</value>
        public IReadOnlyCollection<Notification> Notifications => _notifications.ToList();
        private readonly IList<Notification> _notifications;

        /// <summary>Notifier class constructor.</summary>
        /// <returns>Creates an instance of the Notifier class.</returns>
        protected Notifier()
        {
            _notifications = new List<Notification>();
            Invalid = false;
            Valid = true;
        }

        /// <summary>Add a notification.</summary>
        /// <param name="property">Notification property.</param>
        /// <param name="message">Notification message.</param>
        public void AddNotification(string property, string message)
        {
            Inactivate();

            _notifications.Add(new Notification(property, message));
        }

        /// <summary>Add a notification.</summary>
        /// <param name="notification">Notification.</param>
        public void AddNotification(Notification notification)
        {
            Inactivate();

            _notifications.Add(notification);
        }

        /// <summary>Add a notification list.</summary>
        /// <param name="notifications">list of notifications.</param>
        public void AddNotification(IReadOnlyCollection<Notification> notifications)
        {
            Inactivate();

            if (notifications != null && notifications.Count > 0)
                foreach (var notification in notifications)
                    _notifications.Add(notification);
        }

        /// <summary>Add a notification list.</summary>
        /// <param name="notifications">list of notifications.</param>
        public void AddNotification(IList<Notification> notifications)
        {
            Inactivate();

            if (notifications != null && notifications.Count > 0)
                foreach (var notification in notifications)
                    _notifications.Add(notification);
        }

        /// <summary>Add a notification list.</summary>
        /// <param name="notifications">list of notifications.</param>
        public void AddNotification(ICollection<Notification> notifications)
        {
            Inactivate();

            if (notifications != null && notifications.Count > 0)
                foreach (var notification in notifications)
                    _notifications.Add(notification);
        }

        /// <summary>Adds notifications present in a Notifier.</summary>
        /// <param name="notifier">Notifier.</param>
        public void AddNotification(Notifier notifier)
        {
            Inactivate();

            if (notifier != null && notifier.Notifications != null && notifier.Notifications.Count > 0)
                foreach (var notification in notifier.Notifications)
                    _notifications.Add(notification);
        }

        /// <summary>Adds notifications present in a list of Notifiers.</summary>
        /// <param name="notifiers">Notifiers.</param>
        public void AddNotification(Notifier[] notifiers)
        {
            Inactivate();

            if (notifiers != null && notifiers.Count() > 0)
                foreach (var notifier in notifiers)
                    if (notifier != null && notifier.Notifications.Count > 0)
                        foreach (var notification in notifier.Notifications)
                            _notifications.Add(notification);
        }

        private void Inactivate()
        {
            Valid = false;
            Invalid = true;
        }
    }
}