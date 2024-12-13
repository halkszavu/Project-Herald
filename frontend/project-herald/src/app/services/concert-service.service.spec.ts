import { TestBed } from '@angular/core/testing';

import { ConcertService } from './concert-service.service';

describe('ConcertServiceService', () => {
  let service: ConcertService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ConcertService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
