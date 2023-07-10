import { CanActivateFn } from '@angular/router';

export const privadoGuard: CanActivateFn = (route, state) => {
  return true;
};
