using LSCode.Validations.Notifiable;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace LSCode.Validations.Test.Unit.Notifiable
{
    internal class NotifierTest
    {
        [Test]
        public void Construtor_Success()
        {
            //Act
            var notifier = new Notifier();

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(notifier.Valid, Is.True);
                Assert.That(notifier.Invalid, Is.False);
                Assert.That(notifier.Notifications, Is.Empty);
            });
        }

        [Test]
        public void AddNotification_Add_With_Property_And_Message_Parameters_Success()
        {
            //Arrange
            var property = "NotificationProperty";
            var message = "NotificationMessage";

            var notifier = new Notifier();

            //Act
            notifier.AddNotification(property, message);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(notifier.Valid, Is.False);
                Assert.That(notifier.Invalid, Is.True);
                Assert.That(notifier.Notifications, Is.Not.Empty);
                Assert.That(notifier.Notifications, Has.Count.EqualTo(1));
                Assert.That(notifier.Notifications.ToList()[0].Property, Is.EqualTo(property));
                Assert.That(notifier.Notifications.ToList()[0].Message, Is.EqualTo(message));
            });
        }

        [Test]
        public void AddNotification_Add_With_Notification_Parameters_Success()
        {
            //Arrange
            var property = "NotificationProperty";
            var message = "NotificationMessage";

            var notifier = new Notifier();

            var notification = new Notification(property, message);

            //Act
            notifier.AddNotification(notification);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(notifier.Valid, Is.False);
                Assert.That(notifier.Invalid, Is.True);
                Assert.That(notifier.Notifications, Is.Not.Empty);
                Assert.That(notifier.Notifications, Has.Count.EqualTo(1));
                Assert.That(notifier.Notifications.ToList()[0].Property, Is.EqualTo(property));
                Assert.That(notifier.Notifications.ToList()[0].Message, Is.EqualTo(message));
            });
        }

        [Test]
        public void AddNotification_Add_With_IEnumerable_Of_Notification_Parameter_Success()
        {
            //Arrange
            var property1 = "NotificationProperty1";
            var message1 = "NotificationMessage1";

            var property2 = "NotificationProperty2";
            var message2 = "NotificationMessage2";

            var property3 = "NotificationProperty3";
            var message3 = "NotificationMessage3";

            var notifier = new Notifier();

            IEnumerable<Notification> invalidNotificationList = new List<Notification>
            {
                new Notification(property1, message1),
                new Notification(property2, message2),
                new Notification(property3, message3)
            };

            //Act
            notifier.AddNotification(invalidNotificationList);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(notifier.Valid, Is.False);
                Assert.That(notifier.Invalid, Is.True);
                Assert.That(notifier.Notifications, Is.Not.Empty);
                Assert.That(notifier.Notifications, Has.Count.EqualTo(3));
                Assert.That(notifier.Notifications.ToList()[0].Property, Is.EqualTo(property1));
                Assert.That(notifier.Notifications.ToList()[0].Message, Is.EqualTo(message1));
                Assert.That(notifier.Notifications.ToList()[1].Property, Is.EqualTo(property2));
                Assert.That(notifier.Notifications.ToList()[1].Message, Is.EqualTo(message2));
                Assert.That(notifier.Notifications.ToList()[2].Property, Is.EqualTo(property3));
                Assert.That(notifier.Notifications.ToList()[2].Message, Is.EqualTo(message3));
            });
        }

        [Test]
        public void AddNotification_Add_With_List_Of_Notification_Parameter_Success()
        {
            //Arrange
            var property1 = "NotificationProperty1";
            var message1 = "NotificationMessage1";

            var property2 = "NotificationProperty2";
            var message2 = "NotificationMessage2";

            var property3 = "NotificationProperty3";
            var message3 = "NotificationMessage3";

            var notifier = new Notifier();

            List<Notification> invalidNotificationList = new List<Notification>
            {
                new Notification(property1, message1),
                new Notification(property2, message2),
                new Notification(property3, message3)
            };

            //Act
            notifier.AddNotification(invalidNotificationList);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(notifier.Valid, Is.False);
                Assert.That(notifier.Invalid, Is.True);
                Assert.That(notifier.Notifications, Is.Not.Empty);
                Assert.That(notifier.Notifications, Has.Count.EqualTo(3));
                Assert.That(notifier.Notifications.ToList()[0].Property, Is.EqualTo(property1));
                Assert.That(notifier.Notifications.ToList()[0].Message, Is.EqualTo(message1));
                Assert.That(notifier.Notifications.ToList()[1].Property, Is.EqualTo(property2));
                Assert.That(notifier.Notifications.ToList()[1].Message, Is.EqualTo(message2));
                Assert.That(notifier.Notifications.ToList()[2].Property, Is.EqualTo(property3));
                Assert.That(notifier.Notifications.ToList()[2].Message, Is.EqualTo(message3));
            });
        }

        [Test]
        public void AddNotification_Add_With_IList_Of_Notification_Parameter_Success()
        {
            //Arrange
            var property1 = "NotificationProperty1";
            var message1 = "NotificationMessage1";

            var property2 = "NotificationProperty2";
            var message2 = "NotificationMessage2";

            var property3 = "NotificationProperty3";
            var message3 = "NotificationMessage3";

            var notifier = new Notifier();

            IList<Notification> invalidNotificationList = new List<Notification>
            {
                new Notification(property1, message1),
                new Notification(property2, message2),
                new Notification(property3, message3)
            };

            //Act
            notifier.AddNotification(invalidNotificationList);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(notifier.Valid, Is.False);
                Assert.That(notifier.Invalid, Is.True);
                Assert.That(notifier.Notifications, Is.Not.Empty);
                Assert.That(notifier.Notifications, Has.Count.EqualTo(3));
                Assert.That(notifier.Notifications.ToList()[0].Property, Is.EqualTo(property1));
                Assert.That(notifier.Notifications.ToList()[0].Message, Is.EqualTo(message1));
                Assert.That(notifier.Notifications.ToList()[1].Property, Is.EqualTo(property2));
                Assert.That(notifier.Notifications.ToList()[1].Message, Is.EqualTo(message2));
                Assert.That(notifier.Notifications.ToList()[2].Property, Is.EqualTo(property3));
                Assert.That(notifier.Notifications.ToList()[2].Message, Is.EqualTo(message3));
            });
        }

        [Test]
        public void AddNotification_Add_With_ICollection_Of_Notification_Parameter_Success()
        {
            //Arrange
            var property1 = "NotificationProperty1";
            var message1 = "NotificationMessage1";

            var property2 = "NotificationProperty2";
            var message2 = "NotificationMessage2";

            var property3 = "NotificationProperty3";
            var message3 = "NotificationMessage3";

            var notifier = new Notifier();

            ICollection<Notification> invalidNotificationList = new List<Notification>
            {
                new Notification(property1, message1),
                new Notification(property2, message2),
                new Notification(property3, message3)
            };

            //Act
            notifier.AddNotification(invalidNotificationList);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(notifier.Valid, Is.False);
                Assert.That(notifier.Invalid, Is.True);
                Assert.That(notifier.Notifications, Is.Not.Empty);
                Assert.That(notifier.Notifications, Has.Count.EqualTo(3));
                Assert.That(notifier.Notifications.ToList()[0].Property, Is.EqualTo(property1));
                Assert.That(notifier.Notifications.ToList()[0].Message, Is.EqualTo(message1));
                Assert.That(notifier.Notifications.ToList()[1].Property, Is.EqualTo(property2));
                Assert.That(notifier.Notifications.ToList()[1].Message, Is.EqualTo(message2));
                Assert.That(notifier.Notifications.ToList()[2].Property, Is.EqualTo(property3));
                Assert.That(notifier.Notifications.ToList()[2].Message, Is.EqualTo(message3));
            });
        }

        [Test]
        public void AddNotification_Add_With_IReadOnlyList_Of_Notification_Parameter_Success()
        {
            //Arrange
            var property1 = "NotificationProperty1";
            var message1 = "NotificationMessage1";

            var property2 = "NotificationProperty2";
            var message2 = "NotificationMessage2";

            var property3 = "NotificationProperty3";
            var message3 = "NotificationMessage3";

            var notifier = new Notifier();

            IReadOnlyList<Notification> invalidNotificationList = new List<Notification>
            {
                new Notification(property1, message1),
                new Notification(property2, message2),
                new Notification(property3, message3)
            };

            //Act
            notifier.AddNotification(invalidNotificationList);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(notifier.Valid, Is.False);
                Assert.That(notifier.Invalid, Is.True);
                Assert.That(notifier.Notifications, Is.Not.Empty);
                Assert.That(notifier.Notifications, Has.Count.EqualTo(3));
                Assert.That(notifier.Notifications.ToList()[0].Property, Is.EqualTo(property1));
                Assert.That(notifier.Notifications.ToList()[0].Message, Is.EqualTo(message1));
                Assert.That(notifier.Notifications.ToList()[1].Property, Is.EqualTo(property2));
                Assert.That(notifier.Notifications.ToList()[1].Message, Is.EqualTo(message2));
                Assert.That(notifier.Notifications.ToList()[2].Property, Is.EqualTo(property3));
                Assert.That(notifier.Notifications.ToList()[2].Message, Is.EqualTo(message3));
            });
        }

        [Test]
        public void AddNotification_Add_With_IReadOnlyCollection_Of_Notification_Parameter_Success()
        {
            //Arrange
            var property1 = "NotificationProperty1";
            var message1 = "NotificationMessage1";

            var property2 = "NotificationProperty2";
            var message2 = "NotificationMessage2";

            var property3 = "NotificationProperty3";
            var message3 = "NotificationMessage3";

            var notifier = new Notifier();

            IReadOnlyCollection<Notification> invalidNotificationList = new List<Notification>
            {
                new Notification(property1, message1),
                new Notification(property2, message2),
                new Notification(property3, message3)
            };

            //Act
            notifier.AddNotification(invalidNotificationList);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(notifier.Valid, Is.False);
                Assert.That(notifier.Invalid, Is.True);
                Assert.That(notifier.Notifications, Is.Not.Empty);
                Assert.That(notifier.Notifications, Has.Count.EqualTo(3));
                Assert.That(notifier.Notifications.ToList()[0].Property, Is.EqualTo(property1));
                Assert.That(notifier.Notifications.ToList()[0].Message, Is.EqualTo(message1));
                Assert.That(notifier.Notifications.ToList()[1].Property, Is.EqualTo(property2));
                Assert.That(notifier.Notifications.ToList()[1].Message, Is.EqualTo(message2));
                Assert.That(notifier.Notifications.ToList()[2].Property, Is.EqualTo(property3));
                Assert.That(notifier.Notifications.ToList()[2].Message, Is.EqualTo(message3));
            });
        }

        [Test]
        public void AddNotification_Add_With_Notifier_Parameter_Success()
        {
            //Arrange
            var property = "NotificationProperty";
            var message = "NotificationMessage";

            var notifier = new Notifier();

            var invalidNotifier = new Notifier();
            invalidNotifier.AddNotification(property, message);

            //Act
            notifier.AddNotification(invalidNotifier);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(notifier.Valid, Is.False);
                Assert.That(notifier.Invalid, Is.True);
                Assert.That(notifier.Notifications, Is.Not.Empty);
                Assert.That(notifier.Notifications, Has.Count.EqualTo(1));
                Assert.That(notifier.Notifications.ToList()[0].Property, Is.EqualTo(property));
                Assert.That(notifier.Notifications.ToList()[0].Message, Is.EqualTo(message));
            });
        }

        [Test]
        public void AddNotification_Add_With_IEnumerable_Of_Notifier_Parameter_Success()
        {
            //Arrange
            var property1 = "NotificationProperty1";
            var message1 = "NotificationMessage1";

            var property2 = "NotificationProperty2";
            var message2 = "NotificationMessage2";

            var property3 = "NotificationProperty3";
            var message3 = "NotificationMessage3";

            var notifier = new Notifier();

            var invalidNotifier1 = new Notifier();
            invalidNotifier1.AddNotification(property1, message1);

            var invalidNotifier2 = new Notifier();
            invalidNotifier2.AddNotification(property2, message2);
            invalidNotifier2.AddNotification(property3, message3);

            IEnumerable<Notifier> invalidNotifierList = new List<Notifier>
            {
                invalidNotifier1,
                invalidNotifier2
            };

            //Act
            notifier.AddNotification(invalidNotifierList);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(notifier.Valid, Is.False);
                Assert.That(notifier.Invalid, Is.True);
                Assert.That(notifier.Notifications, Is.Not.Empty);
                Assert.That(notifier.Notifications, Has.Count.EqualTo(3));
                Assert.That(notifier.Notifications.ToList()[0].Property, Is.EqualTo(property1));
                Assert.That(notifier.Notifications.ToList()[0].Message, Is.EqualTo(message1));
                Assert.That(notifier.Notifications.ToList()[1].Property, Is.EqualTo(property2));
                Assert.That(notifier.Notifications.ToList()[1].Message, Is.EqualTo(message2));
                Assert.That(notifier.Notifications.ToList()[2].Property, Is.EqualTo(property3));
                Assert.That(notifier.Notifications.ToList()[2].Message, Is.EqualTo(message3));
            });
        }

        [Test]
        public void AddNotification_Add_With_List_Of_Notifier_Parameter_Success()
        {
            //Arrange
            var property1 = "NotificationProperty1";
            var message1 = "NotificationMessage1";

            var property2 = "NotificationProperty2";
            var message2 = "NotificationMessage2";

            var property3 = "NotificationProperty3";
            var message3 = "NotificationMessage3";

            var notifier = new Notifier();

            var invalidNotifier1 = new Notifier();
            invalidNotifier1.AddNotification(property1, message1);

            var invalidNotifier2 = new Notifier();
            invalidNotifier2.AddNotification(property2, message2);
            invalidNotifier2.AddNotification(property3, message3);

            List<Notifier> invalidNotifierList = new List<Notifier>
            {
                invalidNotifier1,
                invalidNotifier2
            };

            //Act
            notifier.AddNotification(invalidNotifierList);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(notifier.Valid, Is.False);
                Assert.That(notifier.Invalid, Is.True);
                Assert.That(notifier.Notifications, Is.Not.Empty);
                Assert.That(notifier.Notifications, Has.Count.EqualTo(3));
                Assert.That(notifier.Notifications.ToList()[0].Property, Is.EqualTo(property1));
                Assert.That(notifier.Notifications.ToList()[0].Message, Is.EqualTo(message1));
                Assert.That(notifier.Notifications.ToList()[1].Property, Is.EqualTo(property2));
                Assert.That(notifier.Notifications.ToList()[1].Message, Is.EqualTo(message2));
                Assert.That(notifier.Notifications.ToList()[2].Property, Is.EqualTo(property3));
                Assert.That(notifier.Notifications.ToList()[2].Message, Is.EqualTo(message3));
            });
        }

        [Test]
        public void AddNotification_Add_With_IList_Of_Notifier_Parameter_Success()
        {
            //Arrange
            var property1 = "NotificationProperty1";
            var message1 = "NotificationMessage1";

            var property2 = "NotificationProperty2";
            var message2 = "NotificationMessage2";

            var property3 = "NotificationProperty3";
            var message3 = "NotificationMessage3";

            var notifier = new Notifier();

            var invalidNotifier1 = new Notifier();
            invalidNotifier1.AddNotification(property1, message1);

            var invalidNotifier2 = new Notifier();
            invalidNotifier2.AddNotification(property2, message2);
            invalidNotifier2.AddNotification(property3, message3);

            IList<Notifier> invalidNotifierList = new List<Notifier>()
            {
                invalidNotifier1,
                invalidNotifier2
            };

            //Act
            notifier.AddNotification(invalidNotifierList);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(notifier.Valid, Is.False);
                Assert.That(notifier.Invalid, Is.True);
                Assert.That(notifier.Notifications, Is.Not.Empty);
                Assert.That(notifier.Notifications, Has.Count.EqualTo(3));
                Assert.That(notifier.Notifications.ToList()[0].Property, Is.EqualTo(property1));
                Assert.That(notifier.Notifications.ToList()[0].Message, Is.EqualTo(message1));
                Assert.That(notifier.Notifications.ToList()[1].Property, Is.EqualTo(property2));
                Assert.That(notifier.Notifications.ToList()[1].Message, Is.EqualTo(message2));
                Assert.That(notifier.Notifications.ToList()[2].Property, Is.EqualTo(property3));
                Assert.That(notifier.Notifications.ToList()[2].Message, Is.EqualTo(message3));
            });
        }

        [Test]
        public void AddNotification_Add_With_ICollection_Of_Notifier_Parameter_Success()
        {
            //Arrange
            var property1 = "NotificationProperty1";
            var message1 = "NotificationMessage1";

            var property2 = "NotificationProperty2";
            var message2 = "NotificationMessage2";

            var property3 = "NotificationProperty3";
            var message3 = "NotificationMessage3";

            var notifier = new Notifier();

            var invalidNotifier1 = new Notifier();
            invalidNotifier1.AddNotification(property1, message1);

            var invalidNotifier2 = new Notifier();
            invalidNotifier2.AddNotification(property2, message2);
            invalidNotifier2.AddNotification(property3, message3);

            ICollection<Notifier> invalidNotifierList = new List<Notifier>()
            {
                invalidNotifier1,
                invalidNotifier2
            };

            //Act
            notifier.AddNotification(invalidNotifierList);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(notifier.Valid, Is.False);
                Assert.That(notifier.Invalid, Is.True);
                Assert.That(notifier.Notifications, Is.Not.Empty);
                Assert.That(notifier.Notifications, Has.Count.EqualTo(3));
                Assert.That(notifier.Notifications.ToList()[0].Property, Is.EqualTo(property1));
                Assert.That(notifier.Notifications.ToList()[0].Message, Is.EqualTo(message1));
                Assert.That(notifier.Notifications.ToList()[1].Property, Is.EqualTo(property2));
                Assert.That(notifier.Notifications.ToList()[1].Message, Is.EqualTo(message2));
                Assert.That(notifier.Notifications.ToList()[2].Property, Is.EqualTo(property3));
                Assert.That(notifier.Notifications.ToList()[2].Message, Is.EqualTo(message3));
            });
        }

        [Test]
        public void AddNotification_Add_With_IReadOnlyList_Of_Notifier_Parameter_Success()
        {
            //Arrange
            var property1 = "NotificationProperty1";
            var message1 = "NotificationMessage1";

            var property2 = "NotificationProperty2";
            var message2 = "NotificationMessage2";

            var property3 = "NotificationProperty3";
            var message3 = "NotificationMessage3";

            var notifier = new Notifier();

            var invalidNotifier1 = new Notifier();
            invalidNotifier1.AddNotification(property1, message1);

            var invalidNotifier2 = new Notifier();
            invalidNotifier2.AddNotification(property2, message2);
            invalidNotifier2.AddNotification(property3, message3);

            IReadOnlyList<Notifier> invalidNotifierList = new List<Notifier>()
            {
                invalidNotifier1,
                invalidNotifier2
            };

            //Act
            notifier.AddNotification(invalidNotifierList);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(notifier.Valid, Is.False);
                Assert.That(notifier.Invalid, Is.True);
                Assert.That(notifier.Notifications, Is.Not.Empty);
                Assert.That(notifier.Notifications, Has.Count.EqualTo(3));
                Assert.That(notifier.Notifications.ToList()[0].Property, Is.EqualTo(property1));
                Assert.That(notifier.Notifications.ToList()[0].Message, Is.EqualTo(message1));
                Assert.That(notifier.Notifications.ToList()[1].Property, Is.EqualTo(property2));
                Assert.That(notifier.Notifications.ToList()[1].Message, Is.EqualTo(message2));
                Assert.That(notifier.Notifications.ToList()[2].Property, Is.EqualTo(property3));
                Assert.That(notifier.Notifications.ToList()[2].Message, Is.EqualTo(message3));
            });
        }

        [Test]
        public void AddNotification_Add_With_IReadOnlyCollection_Of_Notifier_Parameter_Success()
        {
            //Arrange
            var property1 = "NotificationProperty1";
            var message1 = "NotificationMessage1";

            var property2 = "NotificationProperty2";
            var message2 = "NotificationMessage2";

            var property3 = "NotificationProperty3";
            var message3 = "NotificationMessage3";

            var notifier = new Notifier();

            var invalidNotifier1 = new Notifier();
            invalidNotifier1.AddNotification(property1, message1);

            var invalidNotifier2 = new Notifier();
            invalidNotifier2.AddNotification(property2, message2);
            invalidNotifier2.AddNotification(property3, message3);

            IReadOnlyCollection<Notifier> invalidNotifierList = new List<Notifier>()
            {
                invalidNotifier1,
                invalidNotifier2
            };

            //Act
            notifier.AddNotification(invalidNotifierList);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.That(notifier.Valid, Is.False);
                Assert.That(notifier.Invalid, Is.True);
                Assert.That(notifier.Notifications, Is.Not.Empty);
                Assert.That(notifier.Notifications, Has.Count.EqualTo(3));
                Assert.That(notifier.Notifications.ToList()[0].Property, Is.EqualTo(property1));
                Assert.That(notifier.Notifications.ToList()[0].Message, Is.EqualTo(message1));
                Assert.That(notifier.Notifications.ToList()[1].Property, Is.EqualTo(property2));
                Assert.That(notifier.Notifications.ToList()[1].Message, Is.EqualTo(message2));
                Assert.That(notifier.Notifications.ToList()[2].Property, Is.EqualTo(property3));
                Assert.That(notifier.Notifications.ToList()[2].Message, Is.EqualTo(message3));
            });
        }
    }
}