import { Injectable } from '@angular/core';
import { AuthService } from './auth.service';
import { Permissions } from './permissions';

@Injectable()
export class AclService {
	constructor(private authService: AuthService) {
	}

	isGranted(role: string): boolean {
		let authUser = this.authService.getAuthUser();

		if (!authUser) {
			return false;
		}

		if (typeof Permissions[role] === 'undefined') {
			throw new Error('Role "' + role + '" doesn\'t exists.');
		}

		if (role === 'roleAssignProjectMember') {
			return this.authService.isUserAdminOrManager;
		}

		return !!(Permissions[role] & authUser.role);
	}
}