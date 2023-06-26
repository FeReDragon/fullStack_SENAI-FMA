import { Component } from '@angular/core';
import { notificationsData } from './notifications.data';
import { faCheck, faEye } from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-notification-list',
  templateUrl: './notification-list.component.html',
  styleUrls: ['./notification-list.component.scss']
})
export class NotificationListComponent {
  faCheck = faCheck;
  faEye = faEye;

  toggleReadStatus(notification: any) {
    notification.read = !notification.read;
  }

  notifications = notificationsData.map(notification => ({
    ...notification,
    read: false
  }));
}

