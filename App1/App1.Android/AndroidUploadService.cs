using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using AndroidX.Core.App;

namespace App1.Droid
{
    [Service]
    public  class AndroidUploadService : Service
    {

        public override void OnCreate()
        {
            base.OnCreate();
        }

        public override StartCommandResult OnStartCommand(Intent? intent, [GeneratedEnum] StartCommandFlags flags, int startId)
        {
            string fileName = intent.GetStringExtra("filePath");

            Intent notificationIntent = new Intent(this, typeof(MainActivity));
            PendingIntent pendingIntent = PendingIntent.GetActivity(this, 0, notificationIntent, 0);

            Notification notification = new NotificationCompat.Builder(this, "MYIDVERYSPECIAL")
                .SetContentTitle("Uplaoding this file...")
                .SetContentText(fileName)
                .SetSmallIcon(Resource.Drawable.abc_ab_share_pack_mtrl_alpha)
                .SetContentIntent(pendingIntent)
                .Build();

            StartForeground(1, notification);

            return StartCommandResult.Sticky;
        }

        public override IBinder OnBind(Intent intent)
        {
            return null;
        }
    }
}