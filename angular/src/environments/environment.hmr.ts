export const environment = {
  production: false,
  hmr: true,
  application: {
    name: 'CourseSystem',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44358',
    clientId: 'CourseSystem_App',
    dummyClientSecret: '1q2w3e*',
    scope: 'CourseSystem',
    showDebugInformation: true,
    oidc: false,
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44398',
    },
  },
  localization: {
    defaultResourceName: 'CourseSystem',
  },
};
