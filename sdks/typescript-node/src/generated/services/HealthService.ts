import type { BaseHttpRequest } from '../core/BaseHttpRequest';
/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */
import type { CancelablePromise } from '../core/CancelablePromise';

export class HealthService {
  constructor(public readonly httpRequest: BaseHttpRequest) {}

  /**
   * @returns any The Health Check is successful
   * @throws ApiError
   */
  public check(): CancelablePromise<{
    status?: string;
    info?: Record<string, Record<string, string>> | null;
    error?: Record<string, Record<string, string>> | null;
    details?: Record<string, Record<string, string>>;
  }> {
    return this.httpRequest.request({
      method: 'GET',
      url: '/v1/health/services',
      errors: {
        503: 'The Health Check is not successful',
      },
    });
  }
}
