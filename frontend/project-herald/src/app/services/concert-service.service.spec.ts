import { TestBed } from '@angular/core/testing';

import { ConcertServiceService } from './concert-service.service';

describe('ConcertServiceService', () => {
  let service: ConcertServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ConcertServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
