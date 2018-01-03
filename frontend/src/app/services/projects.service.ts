import { ODataConfiguration } from './odata/config';
import { Http } from '@angular/http';
import { Observable } from 'rxjs';
import { Injectable } from '@angular/core';

import { PagedResult, ODataServiceFactory, ODataService } from './odata';
import { Project } from '../models/project';

@Injectable()
export class ProjectsService {
	readonly odata: ODataService<Project>;

	constructor(private odataFactory: ODataServiceFactory,
	            private http: Http,
	            private odataConfig: ODataConfiguration) {
		this.odata = this.odataFactory.CreateService<Project>('Projects');
	}

	getProjectsWithCount(event, filterStr = '', isActive: boolean = true): Observable<PagedResult<Project>> {
		let filters = [];
		let query = this.odata
			.Query()
			.Top(event.rows)
			.Skip(event.first);

		if (event.sortField) {
			query.OrderBy(event.sortField + ' ' + (event.sortOrder === 1 ? 'asc' : 'desc'));
		} else {
			query.OrderBy('name' + ' ' + (event.sortOrder === 1 ? 'asc' : 'desc'));
		}

		if (filterStr) {
			filters.push('contains(tolower(Name),\'' + filterStr.trim().toLowerCase() + '\')');
		}

		filters.push('IsActive eq ' + isActive);
		query.Filter(filters.join(' and '));

		return query.ExecWithCount().map(res => {
			res.data = res.data.map((x: any) => new Project(x));
			return res;
		});
	}

	getProjects(): Observable<Project[]> {
		let filters = [];
		let query = this.odata
			.Query();

		query.OrderBy('name asc');
		filters.push('IsActive eq true');
		query.Filter(filters.join(' and '));

		return query.Exec().map(res => res.map((x: any) => new Project(x)));
	}

	getProjectByName(name: string): Observable<Project> {
		name = name.trim().toLowerCase();
		if (!name) {
			throw new Error('Please, specify projects name');
		}

		let odata = this.odataFactory.CreateService<Project>('ProjectsNames');

		let query = odata
			.Query()
			.Top(1);

		query.Filter('tolower(Name) eq \'' + name + '\'');

		return query.Exec()
			.flatMap(result => {
				let project = result[0] ? new Project(result[0]) : null;
				return Observable.of(project);
			});
	}

	getManagerProjectsCount(): Observable<number> {
		return this.http.get(this.odataConfig.baseUrl + '/ManagerProjects/$count').map(res => parseInt(res.json()));
	}

	getManagerProjectsWithCount(event, filterStr = '', isActive: boolean = true): Observable<PagedResult<Project>> {
		let odata = this.odataFactory.CreateService<Project>('ManagerProjects');

		let filters = [];
		let query = odata
			.Query()
			.Top(event.rows)
			.Skip(event.first);

		if (event.sortField) {
			query.OrderBy(event.sortField + ' ' + (event.sortOrder === 1 ? 'asc' : 'desc'));
		} else {
			query.OrderBy('name' + ' ' + (event.sortOrder === 1 ? 'asc' : 'desc'));
		}
		if (filterStr) {
			filters.push('contains(tolower(Name),\'' + filterStr.trim().toLowerCase() + '\')');
		}

		filters.push('IsActive eq ' + isActive);
		query.Filter(filters.join(' and '));

		return query.ExecWithCount().map(res => {
			res.data = res.data.map((x: any) => new Project(x));
			return res;
		});
	}

	//  CLIENTS

	getClientProjects(event, filterStr = '', isActive: boolean = true, clientId: number = null): Observable<PagedResult<Project>> {
		let odata = this.odataFactory.CreateService<Project>('Projects');

		let filters = [];
		let query = odata
			.Query()
			.Top(event.rows)
			.Skip(event.first);

		if (event.sortField) {
			query.OrderBy(event.sortField + ' ' + (event.sortOrder === 1 ? 'asc' : 'desc'));
		} else {
			query.OrderBy('name' + ' ' + (event.sortOrder === 1 ? 'asc' : 'desc'));
		}
		if (filterStr) {
			filters.push('contains(tolower(Name),\'' + filterStr.trim().toLowerCase() + '\')');
		}

		filters.push('ClientId eq ' + clientId);

		if (isActive) {
			filters.push('IsActive eq ' + isActive);
		}
		query.Filter(filters.join(' and '));

		return query.ExecWithCount().map(res => {
			res.data = res.data.map((x: any) => new Project(x));
			return res;
		});
	}
}