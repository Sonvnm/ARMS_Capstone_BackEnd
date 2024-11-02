using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;

namespace ARMS_API.Helper
{
    public class FirebaseService
    {
        private static bool _isFirebaseAppCreated = false;

        public static void InitializeFirebase()
        {
            if (!_isFirebaseAppCreated)
            {
                FirebaseApp.Create(new AppOptions()
                {
                    Credential = GoogleCredential.FromFile("arms-acdfc-firebase-adminsdk-k69jb-12c5c29272.json")
                });
                _isFirebaseAppCreated = true;
            }
        }
    }
}
