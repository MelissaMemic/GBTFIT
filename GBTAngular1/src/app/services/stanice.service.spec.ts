import { TestBed } from '@angular/core/testing';

import { StaniceService } from './stanice.service';

describe('StaniceService', () => {
  let service: StaniceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(StaniceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
