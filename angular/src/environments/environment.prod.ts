export const environment = {
  production: true,
  hmr: false,
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
